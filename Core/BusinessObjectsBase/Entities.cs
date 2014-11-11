using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections;
using NHibernate.Expression;
using Core;
using Core.Dal;
using System.Reflection;
using Core.Dal.Expressions;

namespace Core.Bll
{
    public struct OrderBy
    {
        public string PropertyName;
        public bool Ascending;
    }

    public class Entities<T> : BindingList<T>, IBusinessObjectBase, Core.Dal.ITracksDirty 
        where T : IBusinessObjectBase
    {
        protected Validator Validator;
        bool isSorted = false;

        PropertyDescriptor sortedProperty;
        ListSortDirection sortDirection;


        public Entities()
        {
            Validator = new Validator((IBusinessObjectBase)this);

        }

        public Entities(IList<T> list) : base(list)
        {
            Validator = new Validator((IBusinessObjectBase)this);
        }

        public Object Object
        {
            get
            {
                return this;
            }
        }

        public static Entities<T> FromIList(IList<T> list)
        {
            return new Entities<T>(list);
        }

        public static Entities<T> GetAll(ISession session, params Core.Dal.Expressions.CriterionBase[] additionalCriteria)
        {

            IList<Core.Dal.Expressions.CriterionBase> criteria;
            if (additionalCriteria == null)
                criteria = new List<Core.Dal.Expressions.CriterionBase>();
            else
                criteria = new List<Core.Dal.Expressions.CriterionBase>(additionalCriteria);
            return GetAll(session, criteria );
        }

        private static void AppendCompulsoryCriterion(Core.Dal.ISession session, IList<Core.Dal.Expressions.CriterionBase> criterion)
        {
            MethodInfo mi = typeof(T).GetMethod("FillCompulsoryCriterion", new Type[] { typeof(Core.Dal.ISession) });
            if (mi == null) return;

            IList<Core.Dal.Expressions.CriterionBase> cr = mi.Invoke(null, new object[] { session }) as IList<Core.Dal.Expressions.CriterionBase>;
            if (cr == null) return;                
            foreach (Core.Dal.Expressions.CriterionBase item in cr)
            {
                 criterion.Add(item);
            }
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

        public static Entities<T> GetAll(ISession session, IList<CriterionBase> additionalCriteria)
        {
            AppendCompulsoryCriterion(session, additionalCriteria);
            MethodInfo mi = typeof(T).GetMethod("GetAll", BindingFlags.Public | BindingFlags.Static);
            if (mi == null)
            {
                Entities<T> result = new Entities<T>();
                session.CreateAndBuildCriteria<T>(additionalCriteria).SetResultTransformer(NHibernate.CriteriaUtil.DistinctRootEntity).List(result);
                return result;
            }
            else
            {
                return (Entities<T>)mi.Invoke(null, new object[] { session, additionalCriteria });                
            }
        }

        public static Entities<T> GetAllOrderBy(ISession session, Order order, params Core.Dal.Expressions.CriterionBase[] additionalCriteria)
        {
            AppendCompulsoryCriterion(session, additionalCriteria);
            MethodInfo mi = typeof(T).GetMethod("GetAll", BindingFlags.Public | BindingFlags.Static);
            if (mi == null)
            {
                Entities<T> result = new Entities<T>();
                session.CreateAndBuildCriteria<T>(additionalCriteria).SetResultTransformer(NHibernate.CriteriaUtil.DistinctRootEntity).AddOrder(order).SetMaxResults(111500).List(result);
                return result;
            }
            else
            {
                return (Entities<T>)mi.Invoke(null, new object[] { session, additionalCriteria });
            }
        }

        public static Entities<T> GetAllOrderBy(ISession session, Order[] orders, params Core.Dal.Expressions.CriterionBase[] additionalCriteria)
        {
            AppendCompulsoryCriterion(session, additionalCriteria);
            MethodInfo mi = typeof(T).GetMethod("GetAll", BindingFlags.Public | BindingFlags.Static);
            if (mi == null)
            {
                Entities<T> result = new Entities<T>();
                NHibernate.ICriteria crit = session.CreateAndBuildCriteria<T>(additionalCriteria).SetResultTransformer(NHibernate.CriteriaUtil.DistinctRootEntity);
                foreach(Order order in orders)
                {
                    crit.AddOrder(order);
                }
                crit.List(result);
                return result;
            }
            else
            {
                return (Entities<T>)mi.Invoke(null, new object[] { session, additionalCriteria });
            }
        }

        public static Entities<T> GetAllOrderBy(ISession session, Order[] orders, IList<Core.Dal.Expressions.CriterionBase> additionalCriteria)
        {
            AppendCompulsoryCriterion(session, additionalCriteria);
            MethodInfo mi = typeof(T).GetMethod("GetAll", BindingFlags.Public | BindingFlags.Static);
            if (mi == null)
            {
                Entities<T> result = new Entities<T>();
                NHibernate.ICriteria crit = session.CreateAndBuildCriteria<T>(additionalCriteria).SetResultTransformer(NHibernate.CriteriaUtil.DistinctRootEntity);
                foreach (Order order in orders)
                {
                    crit.AddOrder(order);
                }
                crit.List(result);
                return result;
            }
            else
            {
                return (Entities<T>)mi.Invoke(null, new object[] { session, additionalCriteria });
            }
        }

        protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
        {
            sortedProperty = prop;
            sortDirection = direction;

            IComparer<T> pc;

            if (direction == ListSortDirection.Ascending)
            {
                pc = new PropertyComparer<T>(prop);
            }
            else
            {
                pc = new ReversePropertyComparer<T>(prop);
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

        public IList<T> FilterItems ( params Core.Dal.Expressions.CriterionBase [] criteria )
        {            
            IList<T> result = new Entities <T>();
            Dal.Expressions.CriterionBase criterion=null;
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

        #region IBusinessObjectBase Members

        public virtual bool IsDirty
        {
            get
            {
                foreach (T item in Items)
                {
                    ITracksDirty i = (item as ITracksDirty);
                    if (i != null && i.IsDirty) return true;
                }
                return false;
            }

            set
            {

            }
        }

        public Result Validate()
        {
            return Validator.Validate();
        }

        public Result ValidateProperty(string propertyName)
        {
            // TODO: ValidateProperty
            return new Result();
        }

        public bool IsValid
        {
            get { return !Validate().HasErrors; }
        }

        public Result Save(ISession session)
        {
            Result res = new Result();
            foreach (T item in Items)
            {
                ITracksDirty i = (item as ITracksDirty);
                if (i.IsDirty) session.SaveOrUpdate(item);
            }
            return res;
        }

        public TP GetPropertyValue<TP>(string propertyName)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public bool IsActive
        {
            get
            {
                return true;
            }
            set
            {

            }
        }

        /// <summary>
        /// IBusinessObjectBase interface propertu
        /// </summary>
        public string DeleteNotes
        {            
            set
            {

            }
        }

        #endregion


        /// <summary>
        /// Merges designated property values of mergedItems list to the respective items in the collection 
        /// </summary>
        /// <param name="mergedItems"></param>
        /// <param name="prop"></param>
        public void MergeProperty(IList<T> mergedItems, PropertyDescriptor prop)
        {
            foreach (T item in Items)
            {
                int index = mergedItems.IndexOf (item);
                if (index != -1 )
                {
                    prop.SetValue ( item, prop.GetValue ( mergedItems[index] ));
                }
            }
        }


    }

}


    



