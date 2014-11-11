using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

using NHibernate.Engine;

namespace Core.Dal.Impl
{
    class NHChildCollection<T> : NHibernate.Collection.Generic.PersistentGenericBag<T>, IChildCollection<T>
    {
		/// <summary>
		/// Initializes an instance of the <see cref="NHChildCollection{T}"/>
		/// in the <paramref name="session"/>.
		/// </summary>
		/// <param name="session">The <see cref="ISessionImplementor"/> the bag is in.</param>
		public NHChildCollection( ISessionImplementor session )
			: base( session )
		{
		}

		/// <summary>
		/// Initializes an instance of the <see cref="NHChildCollection{T}"/>
		/// that wraps an existing <see cref="IChildCollection{T}"/> in the <paramref name="session"/>.
		/// </summary>
		/// <param name="session">The <see cref="ISessionImplementor"/> the bag is in.</param>
		/// <param name="coll">The <see cref="IList{T}"/> to wrap.</param>
        public NHChildCollection(ISessionImplementor session, IList<T> coll)
			: base( session, coll )
		{
		}

        void InnerList_ListChanged(object sender, ListChangedEventArgs e)
        {
            OnListChanged(e);
        }

        private ListChangedEventArgs _resetEvent = new ListChangedEventArgs(ListChangedType.Reset, -1);
        private ListChangedEventHandler _onListChanged;

        protected virtual void OnListChanged(ListChangedEventArgs ev)
        {
            if (_onListChanged != null)
            {
                _onListChanged(this, ev);
            }
        }

        private bool _initialized = false;
        private void MakeSureItIsInitialized()
        {
            if (!_initialized)
            {
                if (base.Session.IsOpen)
                {
                    if (!base.Session.IsConnected)
                        base.Session.Reconnect();
                }
                Read(); // force initialization    
                _initialized = true;
            }
        }

        private IChildCollection<T> InnerList
        {
            get
            {
                MakeSureItIsInitialized();
                IChildCollection<T> result = this.Entries() as IChildCollection<T>;
                if (result == null)
                {
                    throw new Exception("Wrapped collection is null or doesn't support IChildCollection<T> interface");
                }
                if (_delayedParent != null)
                {
                    result.Parent = _delayedParent;
                    _delayedParent = null;
                }
                return result;
            }
        }


        public new void Add(T o)
        {
            try 
	        {	   
                // Try to avoid delayed adds
                MakeSureItIsInitialized();
                base.Add(o);
            }
            catch (Exception ex)
            {
                throw new Core.TpaisException(o.ToString(), ex);
            }
        }

        int System.Collections.IList.Add(object o)
        {
            try
            {
                MakeSureItIsInitialized();
                base.Write();
                return InnerList.Add(o);
            }
            catch (Exception ex)
            {

                throw new Core.TpaisException(o.ToString(), ex);
            }
        }

        public override void DelayedAddAll(System.Collections.ICollection coll)
        {
            foreach (object o in coll)
            {
                IHasParent hp = o as IHasParent;
                if (hp != null)
                {
                    if (hp.Parent == null)
                        hp.Parent = this.Parent;
                }
            }
            base.DelayedAddAll(coll);
        }

        #region IBindingList Members

        public void AddIndex(PropertyDescriptor property)
        {
            InnerList.AddIndex(property);
        }

        public object AddNew()
        {
            if (!AllowNew)
                throw new InvalidOperationException("List is doesn't support adding of new records");
            System.Reflection.ConstructorInfo ci = typeof(T).GetConstructor(System.Type.EmptyTypes);
            if (ci == null)
                throw new InvalidOperationException(typeof(T).Name + " has no public New(), so AddNew() is not possible");
            T newItem = (T)ci.Invoke(null);
            this.Add(newItem);
            return newItem;
        }

        public bool AllowNew
        {
            get { return InnerList.AllowNew; }
        }

        public bool AllowEdit
        {
            get { return InnerList.AllowEdit; }
        }

        public bool AllowRemove
        {
            get { return InnerList.AllowRemove; }
        }

        public void ApplySort(PropertyDescriptor property, ListSortDirection direction)
        {
            InnerList.ApplySort(property, direction);
        }

        public int Find(PropertyDescriptor property, object key)
        {
            return InnerList.Find(property, key);
        }

        public bool IsSorted
        {
            get { return InnerList.IsSorted; }
        }

        private bool _subscribedToInnerListChanged = false;

        public event ListChangedEventHandler ListChanged
        {
            add
            {
                if (!_subscribedToInnerListChanged)
                {
                    _subscribedToInnerListChanged = true;
                    InnerList.ListChanged += InnerList_ListChanged;
                }
                _onListChanged += value;
            }
            remove
            {
                _onListChanged -= value;
                if (_onListChanged == null) return;
                if (_onListChanged.GetInvocationList().Length == 0 && _subscribedToInnerListChanged)
                {
                    _subscribedToInnerListChanged = false;
                    InnerList.ListChanged -= InnerList_ListChanged;
                }
            }
        }


        public void RemoveIndex(PropertyDescriptor property)
        {
            InnerList.RemoveIndex(property);
        }

        public void RemoveSort()
        {
            InnerList.RemoveSort();
        }

        public ListSortDirection SortDirection
        {
            get { return InnerList.SortDirection; }
        }

        public PropertyDescriptor SortProperty
        {
            get { return InnerList.SortProperty; }
        }

        public bool SupportsChangeNotification
        {
            get { return InnerList.SupportsChangeNotification; }
        }

        public bool SupportsSearching
        {
            get { return InnerList.SupportsSearching; }
        }

        public bool SupportsSorting
        {
            get { return InnerList.SupportsSorting; }
        }

        #endregion

        #region IRaiseItemChangedEvents Members

        public bool RaisesItemChangedEvents
        {
            get { return typeof(T).GetInterface("INotifyPropertyChanged") != null; }
        }

        #endregion

        #region IChildCollection<T> Members

        public IChildCollection<T> FilterItems(params Core.Dal.Expressions.CriterionBase[] criteria)
        {
            return InnerList.FilterItems(criteria);
        }

        public IChildCollection<T> FilterItemsDistinct(params Core.Dal.Expressions.CriterionBase[] criteria)
        {
            return InnerList.FilterItemsDistinct (criteria);
        }

        public System.Collections.IList FilterItemsDistinctByProperty(string criteria)
        {
            return InnerList.FilterItemsDistinctByProperty(criteria);
        }

        public System.Collections.Generic.SortedDictionary<object, IList<object>> FilterItemsDistinctByPropertyWithValue(string criteria)
        {
            return InnerList.FilterItemsDistinctByPropertyWithValue(criteria);
        }

        public System.Collections.Generic.SortedDictionary<object, IList<object>> FilterItemsDistinctByPropertyWithNothingReplaceValue(string criteria)
        {
            return InnerList.FilterItemsDistinctByPropertyWithNothingReplaceValue(criteria);
        }

        public string ToStringWithSeperator(string seperator)
        {
            return InnerList.ToStringWithSeperator(seperator);
        }

        public IChildCollection<T> ActiveItems
        {
            get
            {
                return InnerList.ActiveItems;
            }
        }

        public IChildCollection<T> ActiveItemsWithoutEmpty
        {
            get
            {
                return InnerList.ActiveItemsWithoutEmpty;
            }
        }

        #endregion

        public override string ToString()
        {
            return InnerList.ToString();
        }


        #region IHasParent Members

        private object _delayedParent = null;

        public object Parent
        {
            get
            {
                if (!_initialized)
                    return _delayedParent;
                else
                    return InnerList.Parent;
            }
            set
            {
                if (!_initialized)
                    _delayedParent = value;
                else
                    InnerList.Parent = value;
            }
        }

        #endregion

        #region IValidatable Members

        public bool IsValid
        {
            get { return InnerList.IsValid; }
        }

        #endregion
    }
}
