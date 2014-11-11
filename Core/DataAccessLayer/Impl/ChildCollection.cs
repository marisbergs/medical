using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

using Core.Dal.Expressions;
using System.Reflection;

namespace Core.Dal
{
    public class ChildCollection<T> : BindingList<T>, IChildCollection<T>
    {
        #region IChildCollection<T> Members

        public IChildCollection<T> FilterItems(params CriterionBase[] criteria)
        {
            IChildCollection<T> result = new ChildCollection<T>();
            CriterionBase criterion = null;
            foreach (CriterionBase item in criteria)
            {
                criterion += item;
            }
            foreach (T item in Items)
            {
                if (criterion.EvaluateFor(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }


        public IChildCollection<T> ActiveItems
        {
            get
            {
                IChildCollection<T> res = FilterItems(new Core.Dal.Expressions.Eq("IsActive", true));
                if (res.Count == 0)
                {
                    try
                    {
                        res.AddNew();
                    }
                    catch
                    {
                        MemberInfo[] mi = typeof(T).GetMember(".ctor", BindingFlags.NonPublic | BindingFlags.Instance);
                        if (mi.Length == 0)
                        {
                            return res;
                        }
                        ConstructorInfo ctor = (ConstructorInfo)mi[0];
                        T newObj = (T)ctor.Invoke(null);
                        res.Add(newObj);
                    }                    

                }
                return res;
            }
        }
        public IChildCollection<T> ActiveItemsWithoutEmpty
        {
            get
            {
                IChildCollection<T> res = FilterItems(new Core.Dal.Expressions.Eq("IsActive", true));                
                return res;
            }
        }
        public IChildCollection<T> FilterItemsDistinct(params CriterionBase[] criteria)
        {
            IChildCollection<T> result = new ChildCollection<T>();
            CriterionBase criterion = null;
            foreach (CriterionBase item in criteria)
            {
                criterion += item;
            }
            foreach (T item in Items)
            {
                if (criterion.EvaluateFor(item)&&(!result.Contains (item)))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public System.Collections.IList FilterItemsDistinctByProperty(string criteria)
        {
            System.Collections.IList result = new System.Collections.ArrayList();            
            foreach (T item in Items)
            {
               object obj = ReflectionHelper.GetPropertyValue(item, criteria);
               if ((!result.Contains(obj)))
                {
                    result.Add(obj);
                }
            }
            return result;
        }

        public System.Collections.Generic.SortedDictionary<object, IList<object>> FilterItemsDistinctByPropertyWithValue(string criteria)
        {
            System.Collections.Generic.SortedDictionary<object, IList<object>> result = new System.Collections.Generic.SortedDictionary<object, IList<object>>();
            foreach (T item in Items)
            {
                object obj = ReflectionHelper.GetPropertyValue(item, criteria);
                if (obj != null)
                {
                    if ((!result.ContainsKey(obj)))
                    {
                        result.Add(obj, new List<object>());
                        result[obj].Add(item);
                    }
                    else
                    {
                        result[obj].Add(item);
                    }
                }
            }
            return result;
        }

        public System.Collections.Generic.SortedDictionary<object, IList<object>> FilterItemsDistinctByPropertyWithNothingReplaceValue(string criteria)
        {
            System.Collections.Generic.SortedDictionary<object, IList<object>> result = new System.Collections.Generic.SortedDictionary<object, IList<object>>();
            foreach (T item in Items)
            {
                object obj = ReflectionHelper.GetPropertyValue(item, criteria);
               
                    if (obj == null)
                    {
                        Type _type = ReflectionHelper.GetPropertyType(item.GetType(), criteria);
                        if (_type == typeof (Nullable<decimal>))
                        {
                            obj = Decimal.MinValue;
                        }
                        else if (_type == typeof(decimal))
                        {
                            obj = Decimal.MinValue;
                        }
                        else if (_type == typeof(Nullable<DateTime>))
                        {
                            obj = DateTime.MinValue;
                        }
                        else if (_type == typeof(DateTime))
                        {
                            obj = DateTime.MinValue;
                        }
                        else
                        {
                            obj = "nothing";
                        }
                    }
                if ((!result.ContainsKey(obj)))
                {
                    result.Add(obj, new List<object>());
                    result[obj].Add(item);
                }
                else
                {
                    result[obj].Add(item);
                }
            }
            return result;
        }

        public string ToStringWithSeperator(string seperator)
        {
            StringBuilder sb = new StringBuilder();
            String firstSeparator = "";
            int count = 0;
            foreach (T item in Items)
            {
                count ++;
                sb.Append(firstSeparator);
                if (!string.IsNullOrEmpty(ToString())) 
                {
                    sb.Append(item.ToString());
                    if (Items.Count > count)
                    {
                        sb.Append(seperator);
                    }
                }
            }
            return sb.ToString();
        }



        #endregion

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            String separator = "";
            foreach (T item in Items)
            {
                sb.Append(separator);
                sb.Append(item.ToString());
                separator = " | ";
            }
            return sb.ToString();
        }        

        #region Find and Sort support for BindingList<T>

        PropertyDescriptor sortedProperty;
        ListSortDirection sortDirection;
        bool isSorted = false;

        protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
        {
            sortedProperty = prop;
            sortDirection = direction;

            IComparer<T> pc;

            if (direction == ListSortDirection.Ascending)
            {
                pc = new Core.Bll.PropertyComparer<T>(prop);
            }
            else
            {
                pc = new Core.Bll.ReversePropertyComparer<T>(prop);
            }

            List<T> lst = Items as List<T>;

            lst.Sort(pc);

            isSorted = true;
            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }

        protected override int FindCore(PropertyDescriptor prop, object key)
        {
            string keyValue = key.ToString().ToUpper();
            foreach (T item in Items)
            {
                string itemValue = prop.GetValue(item).ToString();
                if (itemValue.ToUpper().Contains(keyValue)) return IndexOf(item);
            }
            return -1;
        }

        protected override bool SupportsSortingCore
        {
            get
            {
                return true;
            }
        }

        protected override bool SupportsSearchingCore
        {
            get
            {
                return true;
            }
        }

        protected override PropertyDescriptor SortPropertyCore
        {
            get
            {
                return sortedProperty;
            }
        }

        protected override ListSortDirection SortDirectionCore
        {
            get
            {
                return sortDirection;
            }
        }

        protected override bool IsSortedCore
        {
            get
            {
                return isSorted;
            }
        }
        
        #endregion

        #region IHasParent Members

        private object _parent;

        public object Parent
        {
            get { return _parent; }
            set { _parent = value; }
        }

        #endregion

        protected override void OnListChanged(ListChangedEventArgs e)
        {
            try
            {
                base.OnListChanged(e);
            }
            catch (Exception ex) {}
            
            switch (e.ListChangedType)
            {
                case ListChangedType.ItemAdded:
                    if (_parent != null && Items[e.NewIndex] is IHasParent)
                    {
                        ((IHasParent)Items[e.NewIndex]).Parent = _parent;
                    }
                    MakeParentDirty();
                    break;
                case ListChangedType.ItemChanged:
                case ListChangedType.ItemDeleted:
                    MakeParentDirty();
                    break;
            }
        }

        private void MakeParentDirty()
        {
            if (_parent as ITracksDirty != null)
            {
                ((ITracksDirty)_parent).IsDirty = true;
            }
        }

        #region IValidatable Members

        public bool IsValid
        {
            get
            {
                foreach (T item in Items)
                {
                    if (item is Core.Bll.IValidatable)
                    {
                        if (!((Core.Bll.IValidatable)item).IsValid)
                            return false;
                    }
                }
                return true;
            }
        }

        #endregion

        public ChildCollection()
        {
        }

        //public ChildCollection(object parent) : this()
        //{
        //    _parent = parent;
        //}
    }
}
