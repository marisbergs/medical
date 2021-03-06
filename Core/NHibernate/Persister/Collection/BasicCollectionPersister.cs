using System;
using System.Collections;
using System.Data;

using NHibernate.Collection;
using NHibernate.Engine;
using NHibernate.Impl;
using NHibernate.Loader.Collection;
using NHibernate.Persister.Entity;
using NHibernate.Persister.Collection;
using NHibernate.SqlCommand;
using NHibernate.Type;

namespace NHibernate.Persister.Collection
{
	/// <summary>
	/// Collection persister for collections of values and many-to-many associations.
	/// </summary>
	public class BasicCollectionPersister : AbstractCollectionPersister
	{
		public BasicCollectionPersister(
			Mapping.Collection collection,
			ISessionFactoryImplementor factory )
			: base( collection, factory )
		{
		}

		/// <summary>
		/// Generate the SQL DELETE that deletes all rows
		/// </summary>
		/// <returns></returns>
		protected override SqlString GenerateDeleteString()
		{
			SqlDeleteBuilder delete = new SqlDeleteBuilder( Factory )
				.SetTableName( qualifiedTableName )
				.SetIdentityColumn( KeyColumnNames, KeyType );
			if( HasWhere )
			{
				delete.AddWhereFragment( sqlWhereString );
			}
			return delete.ToSqlString();
		}

		/// <summary>
		/// Generate the SQL INSERT that creates a new row
		/// </summary>
		/// <returns></returns>
		protected override SqlString GenerateInsertRowString()
		{
			SqlInsertBuilder insert = new SqlInsertBuilder( Factory )
				.SetTableName( qualifiedTableName )
				.AddColumn( KeyColumnNames, KeyType );
			if( HasIndex )
			{
				insert.AddColumn( IndexColumnNames, IndexType );
			}
			if( hasIdentifier )
			{
				insert.AddColumn( new string[ ] {IdentifierColumnName}, IdentifierType );
			}
			insert.AddColumn( ElementColumnNames, ElementType );

			return insert.ToSqlString();
		}

		/// <summary>
		/// Generate the SQL UPDATE that updates a row
		/// </summary>
		/// <returns></returns>
		protected override SqlString GenerateUpdateRowString()
		{
			SqlUpdateBuilder update = new SqlUpdateBuilder( Factory )
				.SetTableName( qualifiedTableName )
				.AddColumns( ElementColumnNames, ElementType );
			if( hasIdentifier )
			{
				update.AddWhereFragment( new string[] { IdentifierColumnName }, IdentifierType, " = " );
			}
			else if( HasIndex /* && !indexContainsFormula */ )
			{
				update.AddWhereFragment( KeyColumnNames, KeyType, " = " )
					.AddWhereFragment( IndexColumnNames, IndexType, " = " );
			}
			else
			{
				update.AddWhereFragment( KeyColumnNames, KeyType, " = " )
					.AddWhereFragment( ElementColumnNames, ElementType, " = " );
			}

			return update.ToSqlString();
		}

		/// <summary>
		/// Generate the SQL DELETE that deletes a particular row
		/// </summary>
		/// <returns></returns>
		protected override SqlString GenerateDeleteRowString()
		{
			SqlDeleteBuilder delete = new SqlDeleteBuilder( Factory );
			delete.SetTableName( qualifiedTableName );
			if( hasIdentifier )
			{
				delete.AddWhereFragment( new string[] { IdentifierColumnName }, IdentifierType, " = " );
			}
			else if( HasIndex /*&& !indexContainsFormula*/ )
			{
				delete
					.AddWhereFragment( KeyColumnNames, KeyType, " = " )
					.AddWhereFragment( IndexColumnNames, IndexType, " = " );
			}
			else
			{
				delete
					.AddWhereFragment( KeyColumnNames, KeyType, " = " )
					.AddWhereFragment( ElementColumnNames, ElementType, " = " );
			}

			return delete.ToSqlString();
		}

		public override bool ConsumesEntityAlias()
		{
			return false;
		}

		public override bool ConsumesCollectionAlias()
		{
			return true;
		}


		public override bool IsOneToMany
		{
			get { return false; }
		}

		public override bool IsManyToMany
		{
			get { return ElementType.IsEntityType; }
		}

		protected override int DoUpdateRows( object id, IPersistentCollection collection, ISessionImplementor session )
		{
			try
			{
				IDbCommand st = null;
				IEnumerable entries = collection.Entries();
				try
				{
					int i = 0;
					int count = 0;
					foreach( object entry in entries )
					{
						int offset = 0;
						if( collection.NeedsUpdating( entry, i, ElementType ) )
						{
							if( st == null )
							{
								st = session.Batcher.PrepareBatchCommand( SqlUpdateRowString );
							}
							
							int loc = WriteElement( st, collection.GetElement( entry ), offset, session );
							if( hasIdentifier )
							{
								loc = WriteIdentifier( st, collection.GetIdentifier( entry, i ), loc, session );
							}
							else
							{
								loc = WriteKey( st, id, loc, session );
								if( HasIndex /* && !indexContainsFormula */)
								{
									loc = WriteIndexToWhere( st, collection.GetIndex( entry, i ), loc, session );
								}
								else
								{
									loc = WriteElementToWhere( st, collection.GetSnapshotElement( entry, i ), loc, session );
								}
							}
							session.Batcher.AddToBatch( 1 );
							count++;
						}
						i++;
					}
					return count;
				}
				catch( Exception e )
				{
					//TODO: change to SqlException
					// NB This calls cmd.Dispose
					session.Batcher.AbortBatch( e );
					throw;
				}
			}
			catch( HibernateException )
			{
				// Do not call Convert on HibernateExceptions
				throw;
			}
			catch( Exception sqle )
			{
				throw Convert( sqle, "could not update collection rows: " + MessageHelper.InfoString( this, id ) );
			}
		}

		/// <summary>
		/// Create the <see cref="CollectionLoader" />
		/// </summary>
		protected override ICollectionInitializer CreateCollectionInitializer( IDictionary enabledFilters )
		{
			return BatchingCollectionInitializer.CreateBatchingCollectionInitializer( this, batchSize, Factory, enabledFilters );
		}

		public override SqlString FromJoinFragment( string alias, bool innerJoin, bool includeSubclasses )
		{
			return SqlString.Empty;
		}

		public override SqlString WhereJoinFragment( string alias, bool innerJoin, bool includeSubclasses )
		{
			return SqlString.Empty;
		}

		public override string SelectFragment(
			IJoinable rhs,
			string rhsAlias,
			string lhsAlias,
			string entitySuffix,
			string collectionSuffix,
			bool includeCollectionColumns )
		{
			// we need to determine the best way to know that two joinables
			// represent a single many-to-many...
			if ( rhs != null && IsManyToMany && !rhs.IsCollection ) 
			{
				IAssociationType elementType = ( IAssociationType ) ElementType;
				if ( rhs.Equals( elementType.GetAssociatedJoinable( Factory ) ) ) 
				{
					return ManyToManySelectFragment( rhs, rhsAlias, lhsAlias, collectionSuffix );
				}
			}
			return includeCollectionColumns ? SelectFragment( lhsAlias, collectionSuffix ) : string.Empty;
		}

		private string ManyToManySelectFragment(
			IJoinable rhs,
			string rhsAlias,
			string lhsAlias,
			string collectionSuffix )
		{
			SelectFragment frag = GenerateSelectFragment( lhsAlias, collectionSuffix );

			string[] elementColumnNames = rhs.KeyColumnNames;
			frag.AddColumns( rhsAlias, elementColumnNames, elementColumnAliases );
			AppendIndexColumns( frag, lhsAlias );
			AppendIdentifierColumns( frag, lhsAlias );

			return frag.ToSqlStringFragment( false );
		}
	}
}