using System;
using System.Collections.Generic;
using System.Text;

using Core.Bll;

namespace Core.Dal.Impl
{
    public class ChildCollectionType<ChildType> : NHibernate.UserType.IUserCollectionType //NHibernate.UserType.IUserCollectionType
    {
        #region IUserCollectionType Members

        public NHibernate.Collection.IPersistentCollection Instantiate(NHibernate.Engine.ISessionImplementor session, NHibernate.Persister.Collection.ICollectionPersister persister)
        {
            return new NHChildCollection<ChildType>(session);
        }

        public NHibernate.Collection.IPersistentCollection Wrap(NHibernate.Engine.ISessionImplementor session, object collection)
        {
            return new NHChildCollection<ChildType>(session, (IList<ChildType>)collection);
        }

        public System.Collections.IEnumerable GetElements(object collection)
        {
            return (System.Collections.IEnumerable)collection;
        }

        public bool Contains(object collection, object entity)
        {
            return ((System.Collections.IList)collection).Contains(entity);
        }

        public object IndexOf(object collection, object entity)
        {
            return ((System.Collections.IList)collection).IndexOf(entity);
        }

        public object ReplaceElements(object original, object target, NHibernate.Persister.Collection.ICollectionPersister persister, object owner, System.Collections.IDictionary copyCache, NHibernate.Engine.ISessionImplementor session)
        {
            System.Collections.IList result = (System.Collections.IList)target;
            result.Clear();
            foreach (object o in ((System.Collections.IEnumerable)original))
            {
                result.Add(o);
            }
            return result;
        }

        public virtual object Instantiate()
        {
            return new ChildCollection<ChildType>();
        }

        #endregion
    }
}
