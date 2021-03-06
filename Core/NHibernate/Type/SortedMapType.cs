using System;
using System.Collections;

using NHibernate.Collection;
using NHibernate.Engine;
using NHibernate.Persister.Collection;

namespace NHibernate.Type
{
	/// <summary>
	/// Extends the <see cref="MapType" /> to provide sorting.
	/// </summary>
	[Serializable]
	public class SortedMapType : MapType
	{
		private IComparer comparer;

		/// <summary>
		/// Initializes a new instance of a <see cref="SortedMapType"/> class for
		/// a specific role using the <see cref="IComparer"/> to do the sorting.
		/// </summary>
		/// <param name="role">The role the persistent collection is in.</param>
		/// <param name="comparer">The <see cref="IComparer"/> to use for the sorting.</param>
		public SortedMapType( string role, string propertyRef, IComparer comparer )
			: base( role, propertyRef )
		{
			this.comparer = comparer;
		}

		public IComparer Comparer
		{
			get { return comparer; }
		}

		public override object Instantiate()
		{
			return new SortedList( comparer );
		}
	}
}