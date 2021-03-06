using System;
using System.Collections;
using NHibernate.Engine;
using NHibernate.SqlCommand;
using NHibernate.Util;

namespace NHibernate.Expression
{
	/// <summary>
	/// A sequence of logical <see cref="ICriterion"/>s combined by some associative
	/// logical operator.
	/// </summary>
	public abstract class Junction : AbstractCriterion
	{
		private IList _criteria = new ArrayList();

		/// <summary>
		/// Adds an <see cref="ICriterion"/> to the list of <see cref="ICriterion"/>s
		/// to junction together.
		/// </summary>
		/// <param name="criterion">The <see cref="ICriterion"/> to add.</param>
		/// <returns>
		/// This <see cref="Junction"/> instance.
		/// </returns>
		public Junction Add( ICriterion criterion )
		{
			_criteria.Add( criterion );
			return this;
		}

		/// <summary>
		/// Get the Sql operator to put between multiple <see cref="ICriterion"/>s.
		/// </summary>
		protected abstract String Op { get; }

		public override TypedValue[ ] GetTypedValues( ICriteria criteria, ICriteriaQuery criteriaQuery )
		{
			ArrayList typedValues = new ArrayList();

			foreach( ICriterion criterion in _criteria )
			{
				TypedValue[ ] subvalues = criterion.GetTypedValues( criteria, criteriaQuery );
				ArrayHelper.AddAll( typedValues, subvalues );
			}

			return ( TypedValue[ ] ) typedValues.ToArray( typeof( TypedValue ) );

		}

		public override SqlString ToSqlString( ICriteria criteria, ICriteriaQuery criteriaQuery )
		{
			if( _criteria.Count == 0 )
			{
				return new SqlString( "1=1" );
			}

			//TODO: add default capacity
			SqlStringBuilder sqlBuilder = new SqlStringBuilder();

			sqlBuilder.Add( "(" );

			for( int i = 0; i < _criteria.Count - 1; i++ )
			{
				sqlBuilder.Add(
					( ( ICriterion ) _criteria[ i ] ).ToSqlString( criteria, criteriaQuery ) );
				sqlBuilder.Add( Op );
			}

			sqlBuilder.Add(
				( ( ICriterion ) _criteria[ _criteria.Count - 1 ] ).ToSqlString( criteria, criteriaQuery ) );


			sqlBuilder.Add( ")" );

			return sqlBuilder.ToSqlString();
		}

		public override string ToString()
		{
			return '(' + StringHelper.Join( Op, _criteria ) + ')';
		}
	}
}