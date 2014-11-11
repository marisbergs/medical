using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

using System.Reflection;

namespace Core.Dal
{
    public class Session : ISession
    {
        private NHibernate.ISession _hSession;
        private IInterceptor _interceptor;

        internal Session(NHibernate.ISession hSession, IInterceptor interceptor)
        {
            _hSession = hSession;
            _interceptor = interceptor;
        }

        #region NHibernate.ISession Members

        void NHibernate.ISession.Flush()
        {
            _hSession.Flush();
        }

        NHibernate.FlushMode NHibernate.ISession.FlushMode
        {
            get
            {
                return _hSession.FlushMode;
            }
            set
            {
                _hSession.FlushMode = value;
            }
        }

        NHibernate.ISessionFactory NHibernate.ISession.SessionFactory
        {
            get { return _hSession.SessionFactory; }
        }

        System.Data.IDbConnection NHibernate.ISession.Connection
        {
            get { return _hSession.Connection; }
        }

        System.Data.IDbConnection NHibernate.ISession.Disconnect()
        {
            return _hSession.Disconnect();
        }

        void NHibernate.ISession.Reconnect()
        {
            _hSession.Reconnect();
        }

        void NHibernate.ISession.Reconnect(System.Data.IDbConnection connection)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        System.Data.IDbConnection NHibernate.ISession.Close()
        {
            return _hSession.Close();
        }

        void NHibernate.ISession.CancelQuery()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        bool NHibernate.ISession.IsOpen
        {
            get { return _hSession.IsOpen; }
        }

        bool NHibernate.ISession.IsConnected
        {
            get { return _hSession.IsConnected; }
        }

        bool NHibernate.ISession.IsDirty()
        {
            return _hSession.IsDirty();
        }

        object NHibernate.ISession.GetIdentifier(object obj)
        {
            return _hSession.GetIdentifier(obj);
        }

        bool NHibernate.ISession.Contains(object obj)
        {
            return _hSession.Contains(obj);
        }

        /// <summary>
        /// Is there an instance associated with this Session?
        /// </summary>
        /// <param name="theType">A persistent class</param>
        /// <param name="id">A valid identifier of an instance of the class</param>
        /// <returns>true if the given instance is associated with this Session</returns>
        bool NHibernate.ISession.Contains(System.Type theType, object id)
        {
            return _hSession.Contains(theType, id);
        }

        void NHibernate.ISession.Evict(object obj)
        {
            _hSession.Evict(obj);
        }

        object NHibernate.ISession.Load(Type theType, object id, NHibernate.LockMode lockMode)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        object NHibernate.ISession.Load(Type theType, object id)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        /// <summary>
        /// Return the persistent instance of the given entity class with the given identifier,
        /// obtaining the specified lock mode.
        /// </summary>
        /// <typeparam name="T">A persistent class</typeparam>
        /// <param name="id">A valid identifier of an existing persistent instance of the class</param>
        /// <param name="lockMode">The lock level</param>
        /// <returns>the persistent instance</returns>
        T NHibernate.ISession.Load<T>(object id, NHibernate.LockMode lockMode)
        {
            return _hSession.Load<T>(id, lockMode);
        }

        /// <summary>
        /// Return the persistent instance of the given entity class with the given identifier,
        /// assuming that the instance exists.
        /// </summary>
        /// <remarks>
        /// You should not use this method to determine if an instance exists (use <see cref="NHibernate.ISession.Find(string)" />
        /// or its overloads instead). Use this only to retrieve an instance that you assume exists, where non-existence
        /// would be an actual error.
        /// </remarks>
        /// <typeparam name="T">A persistent class</typeparam>
        /// <param name="id">A valid identifier of an existing persistent instance of the class</param>
        /// <returns>The persistent instance or proxy</returns>
        T NHibernate.ISession.Load<T>(object id)
        {
            return _hSession.Load<T>(id);
        }

        void NHibernate.ISession.Load(object obj, object id)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        /// <summary>
        /// Persist all reachable transient objects, reusing the current identifier 
        /// values. Note that this will not trigger the Interceptor of the Session.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="replicationMode"></param>
        void NHibernate.ISession.Replicate(object obj, NHibernate.ReplicationMode replicationMode)
        {
            _hSession.Replicate(obj, replicationMode);
        }

        /// <summary>
        /// Persist the given transient instance, first assigning a generated identifier.
        /// </summary>
        /// <remarks>
        /// Save will use the current value of the identifier property if the <c>Assigned</c>
        /// generator is used.
        /// </remarks>
        /// <param name="obj">A transient instance of a persistent class</param>
        /// <returns>The generated identifier</returns>
        object NHibernate.ISession.Save(object obj)
        {
            _hSession.SaveOrUpdate(obj);
            return _hSession.GetIdentifier(obj);
        }

        void NHibernate.ISession.Save(object obj, object id)
        {
            _hSession.Save(obj, id);
        }

        /// <summary>
        /// Either <c>Save()</c> or <c>Update()</c> the given instance, depending upon the value of
        /// its identifier property.
        /// </summary>
        /// <remarks>
        /// By default the instance is always saved. This behaviour may be adjusted by specifying
        /// an <c>unsaved-value</c> attribute of the identifier property mapping
        /// </remarks>
        /// <param name="obj">A transient instance containing new or updated state</param>
        void NHibernate.ISession.SaveOrUpdate(object obj)
        {
            _hSession.SaveOrUpdate(obj);
        }

        void NHibernate.ISession.Update(object obj)
        {
            _hSession.Update(obj);
        }

        void NHibernate.ISession.Update(object obj, object id)
        {
           throw new Exception("The method or operation is not implemented.");
        }

        /// <summary>
        /// Copy the state of the given object onto the persistent object with the same
        /// identifier. If there is no persistent instance currently associated with 
        /// the session, it will be loaded. Return the persistent instance. If the 
        /// given instance is unsaved or does not exist in the database, save it and 
        /// return it as a newly persistent instance. Otherwise, the given instance
        /// does not become associated with the session.
        /// </summary>
        /// <param name="obj">a transient instance with state to be copied</param>
        /// <returns>an updated persistent instance</returns>
        object NHibernate.ISession.SaveOrUpdateCopy(object obj)
        {
            return _hSession.SaveOrUpdateCopy(obj);
        }

        object NHibernate.ISession.SaveOrUpdateCopy(object obj, object id)
        {
            return _hSession.SaveOrUpdateCopy(obj, id);
        }

        void NHibernate.ISession.Delete(object obj)
        {
            _hSession.Delete(obj);
        }

        System.Collections.IList NHibernate.ISession.Find(string query)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        System.Collections.IList NHibernate.ISession.Find(string query, object value, NHibernate.Type.IType type)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        System.Collections.IList NHibernate.ISession.Find(string query, object[] values, NHibernate.Type.IType[] types)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        System.Collections.IEnumerable NHibernate.ISession.Enumerable(string query)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        System.Collections.IEnumerable NHibernate.ISession.Enumerable(string query, object value, NHibernate.Type.IType type)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        System.Collections.IEnumerable NHibernate.ISession.Enumerable(string query, object[] values, NHibernate.Type.IType[] types)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        System.Collections.ICollection NHibernate.ISession.Filter(object collection, string filter)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        System.Collections.ICollection NHibernate.ISession.Filter(object collection, string filter, object value, NHibernate.Type.IType type)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        System.Collections.ICollection NHibernate.ISession.Filter(object collection, string filter, object[] values, NHibernate.Type.IType[] types)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        int NHibernate.ISession.Delete(string query)
        {
            return _hSession.Delete(query);
        }

        int NHibernate.ISession.Delete(string query, object value, NHibernate.Type.IType type)
        {
            return _hSession.Delete(query, value, type);
        }

        int NHibernate.ISession.Delete(string query, object[] values, NHibernate.Type.IType[] types)
        {
            return _hSession.Delete(query, values, types);
        }

        void NHibernate.ISession.Lock(object obj, NHibernate.LockMode lockMode)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        /// <summary>
        /// Re-read the state of the given instance from the underlying database.
        /// </summary>
        /// <remarks>
        /// <para>
        /// It is inadvisable to use this to implement long-running sessions that span many
        /// business tasks. This method is, however, useful in certain special circumstances.
        /// </para>
        /// <para>
        /// For example,
        /// <list>
        ///		<item>Where a database trigger alters the object state upon insert or update</item>
        ///		<item>After executing direct SQL (eg. a mass update) in the same session</item>
        ///		<item>After inserting a <c>Blob</c> or <c>Clob</c></item>
        /// </list>
        /// </para>
        /// </remarks>
        /// <param name="obj">A persistent instance</param>
        void NHibernate.ISession.Refresh(object obj)
        {
            _hSession.Refresh(obj);
        }

        void NHibernate.ISession.Refresh(object obj, NHibernate.LockMode lockMode)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        NHibernate.LockMode NHibernate.ISession.GetCurrentLockMode(object obj)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        NHibernate.ITransaction NHibernate.ISession.BeginTransaction()
        {
            return _hSession.BeginTransaction();
        }

        NHibernate.ITransaction NHibernate.ISession.BeginTransaction(System.Data.IsolationLevel isolationLevel)
        {
            return _hSession.BeginTransaction(isolationLevel);
        }

        NHibernate.ITransaction NHibernate.ISession.Transaction
        {
            get { return _hSession.Transaction; }
        }

        /// <summary>
        /// Creates a new <c>Criteria</c> for the entity class.
        /// </summary>
        /// <param name="persistentClass">The class to Query</param>
        /// <returns>An ICriteria object</returns>
        NHibernate.ICriteria NHibernate.ISession.CreateCriteria(Type persistentClass)
        {
            return _hSession.CreateCriteria(persistentClass);
        }

        /// <summary>
        /// Create a new instance of <c>Query</c> for the given query string
        /// </summary>
        /// <param name="queryString">A hibernate query string</param>
        /// <returns>The query</returns>
        NHibernate.IQuery NHibernate.ISession.CreateQuery(string queryString)
        {
            return _hSession.CreateQuery(queryString);
        }

        /// <summary>
        /// Create a new instance of <c>Query</c> for the given collection and filter string
        /// </summary>
        /// <param name="collection">A persistent collection</param>
        /// <param name="queryString">A hibernate query</param>
        /// <returns>A query</returns>
        NHibernate.IQuery NHibernate.ISession.CreateFilter(object collection, string queryString)
        {
            return _hSession.CreateFilter(collection, queryString);
        }

        NHibernate.IQuery NHibernate.ISession.GetNamedQuery(string queryName)
        {
            return _hSession.GetNamedQuery(queryName);
        }

        NHibernate.IQuery NHibernate.ISession.CreateSQLQuery(string sql, string returnAlias, Type returnClass)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        NHibernate.IQuery NHibernate.ISession.CreateSQLQuery(string sql, string[] returnAliases, Type[] returnClasses)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void NHibernate.ISession.Clear()
        {
            _hSession.Clear();
        }

        /// <summary>
        /// Return the persistent instance of the given entity class with the given identifier, or null
        /// if there is no such persistent instance. (If the instance, or a proxy for the instance, is
        /// already associated with the session, return that instance or proxy.)
        /// </summary>
        /// <param name="clazz">a persistent class</param>
        /// <param name="id">an identifier</param>
        /// <returns>a persistent instance or null</returns>
        object NHibernate.ISession.Get(Type clazz, object id)
        {
            return _hSession.Get(clazz, id);
        }

        /// <summary>
        /// Return the persistent instance of the given entity class with the given identifier, or null
        /// if there is no such persistent instance. Obtain the specified lock mode if the instance
        /// exists.
        /// </summary>
        /// <param name="clazz">a persistent class</param>
        /// <param name="id">an identifier</param>
        /// <param name="lockMode">the lock mode</param>
        /// <returns>a persistent instance or null</returns>
        object NHibernate.ISession.Get(Type clazz, object id, NHibernate.LockMode lockMode)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        /// <summary>
        /// Strongly-typed version of <see cref="NHibernate.ISession.Get(System.Type, object)" />
        /// </summary>
        T NHibernate.ISession.Get<T>(object id)
        {
            try
            {
                T result = _hSession.Get<T>(id);
                if (result != null && result is IConstrained)
                {
                    if (!((IConstrained)result).CanSee)
                    {
                        _hSession.Evict(result);
                        result = default(T);
                    }
                }
                return result;
            }
            catch (ObjectDisposedException ex)
            {
                // check for PartnerSesions if partner form is closed then sesion is disposed too
            }
            return default(T);
        }

        T NHibernate.ISession.Get<T>(object id, NHibernate.LockMode lockMode)
        {
            T result = _hSession.Get<T>(id, lockMode);
            if (result != null && result is IConstrained)
            {
                if (!((IConstrained)result).CanSee)
                {
                    // Iespējams, Evict pats prastos atlock'ot, bet nu došības pēc...
                    if (lockMode.GreaterThan(NHibernate.LockMode.None))
                        _hSession.Lock(result, NHibernate.LockMode.None);
                    _hSession.Evict(result);
                    result = default(T);
                }
            }
            return result;
        }

        #endregion

        #region IDisposable Members

        void IDisposable.Dispose()
        {
            Manager.Instance.UnregisterSessionWrapper(_hSession);
            _hSession.Dispose();
        }

        #endregion

        #region ISession Members

        NHibernate.ICriteria ISession.CreateAndBuildCriteria<T>(IList<Expressions.CriterionBase> criteria)
        {
            // Create criteria
            NHibernate.ICriteria result = _hSession.CreateCriteria(typeof(T));
            
            // Paskatās, vai klasei nav statiskā metode ar compulsory criteria
            IList<Expressions.CriterionBase> compulsoryCriteria = null;
            MethodInfo mi = typeof(T).GetMethod("CompulsoryCriteria", BindingFlags.Public | BindingFlags.Static);
            if (mi != null)
                compulsoryCriteria = (mi.Invoke(null, null) as IList<Expressions.CriterionBase>);


            if ((criteria != null && criteria.Count != 0) || (compulsoryCriteria != null && compulsoryCriteria.Count != 0))
            {
                // Collect property names
                IDictionary<string, string> propertyNames = new Dictionary<string, string>();
                if (criteria != null)
                {
                    foreach (Expressions.CriterionBase cb in criteria)
                    {
                        if (cb != null)
                            cb.collectPropertyNames(propertyNames);
                    }
                }
                if (compulsoryCriteria != null)
                {
                    foreach (Expressions.CriterionBase cb in compulsoryCriteria)
                    {
                        if (cb != null)
                            cb.collectPropertyNames(propertyNames);
                    }
                }

                // Collect paths and build aliases
                IDictionary<string, string> aliases = new Dictionary<string, string>();
                IDictionary<string, string> names = new Dictionary<string, string>();
                foreach (string pathName in propertyNames.Keys)
                {
                    if (pathName.Split('.').Length > 2)
                    {
                        int i = 2;
                        foreach (string var in pathName.Split('.'))
                        {
                            if (i < pathName.Split('.').Length)
                            {
                                string path = var; // Not including last '.'
                                string name = var;
                                int temp = pathName.LastIndexOf(var);
                                if (!aliases.ContainsKey(path))
                                    aliases[path] = new StringBuilder("_").Append(pathName.Substring(0, temp + var.Length).Replace('.', '_')).ToString();
                                // Build aliased name
                                names[name] = new StringBuilder(aliases[path]).ToString();
                                i++;
                            }
                        }
                    }
                        int lastDot = pathName.LastIndexOf('.');
                        if (lastDot != -1)
                        {
                            string path = pathName.Substring(0, lastDot); // Not including last '.'
                            string name = pathName.Substring(lastDot + 1);
                            if (!aliases.ContainsKey(path))
                                aliases[path] = new StringBuilder("_").Append(path.Replace('.', '_')).ToString();
                            // Build aliased name
                            names[pathName] = new StringBuilder(aliases[path]).Append(".").Append(name).ToString();
                        }
                        else
                            names[pathName] = pathName;                   
                    
                }

                // First add all aliases
                foreach (KeyValuePair<string, string> alias in aliases)
                    result.CreateAlias(alias.Key, alias.Value);

                // Now add all criteria
                if (criteria != null)
                {
                    foreach (Expressions.CriterionBase cb in criteria)
                    {
                        if (cb != null)
                            result.Add(NHibernateTranslator.Translate(cb, names));
                    }
                }
                if (compulsoryCriteria != null)
                {
                    foreach (Expressions.CriterionBase cb in criteria)
                    {
                        if (cb != null)
                            result.Add(NHibernateTranslator.Translate(cb, names));
                    }
                }
            }
            return result;
        }

        void ISession.Commit()
        {
            FlushAndClearDirty();
            RefreshSisterSessions();
        }

        [Obsolete("Obsolete. Commit() will do")]
        void ISession.Commit(ISession partner)
        {
            (this as ISession).Commit();
        }

        private void RefreshSisterSessions()
        {
            foreach (Core.Dal.ISession ss in Manager.Instance.GetCoreSisterSessions(this))
            {
                bool disconnectNeeded = false;
                foreach (DictionaryEntry e in _interceptor.FlushedEntities)
                {
                    object obj = e.Key;
                    object id = e.Value;                    
                    if (id != null)
                    {
                        if (ss.Contains(obj.GetType(), id))
                        {
                            if (_hSession.Contains(obj))
                            {
                                if (!ss.IsConnected)
                                {
                                    ss.Reconnect();
                                    disconnectNeeded = true;
                                }
                                ss.Refresh(ss.Get(obj.GetType(), id));
                            }
                            else
                            {
                                // Object was deleted
                                ss.Evict(ss.Get(obj.GetType(), id));
                            }
                        }
                        //else if(obj is IHasParent)
                        //{
                        //    object _parent = ((IHasParent)obj).Parent;
                        //    if (_parent is NHibernate.Proxy.INHibernateProxy)
                        //    {
                        //        NHibernate.Proxy.INHibernateProxy proxy = (NHibernate.Proxy.INHibernateProxy)_parent;
                        //        NHibernate.Proxy.LazyInitializer li = NHibernate.Proxy.NHibernateProxyHelper.GetLazyInitializer(proxy);
                        //        //NHibernate.Proxy.ReassociateProxy(li, proxy);
                        //        _parent =li.GetImplementation();
                        //    }
                        //    if (ss.Contains(_parent.GetType(), ((Core.Bll.IBusinessObjectBase)_parent).GetPropertyValue<Guid>("Id")))
                        //    {
                        //        if (_hSession.Contains(_parent))
                        //        {
                        //            if (!ss.IsConnected)
                        //            {
                        //                ss.Reconnect();
                        //                disconnectNeeded = true;
                        //            }
                        //            ss.Refresh(ss.Get(_parent.GetType(), ((Core.Bll.IBusinessObjectBase)_parent).GetPropertyValue<Guid>("Id")));
                        //        }
                        //    }
                        //}
                    }
                    //else if (obj is IHasParent)
                    //{
                    //    object _parent = ((IHasParent)obj).Parent;
                    //    if (_parent is NHibernate.Proxy.INHibernateProxy)
                    //    {
                    //        NHibernate.Proxy.INHibernateProxy proxy = (NHibernate.Proxy.INHibernateProxy)_parent;
                    //        NHibernate.Proxy.LazyInitializer li = NHibernate.Proxy.NHibernateProxyHelper.GetLazyInitializer(proxy);
                    //        //NHibernate.Proxy.ReassociateProxy(li, proxy);
                    //        _parent = li.GetImplementation();
                    //    }
                    //    if (ss.Contains(_parent.GetType(), ((Core.Bll.IBusinessObjectBase)_parent).GetPropertyValue<Guid>("Id")))
                    //    {
                    //        if (_hSession.Contains(_parent))
                    //        {
                    //            if (!ss.IsConnected)
                    //            {
                    //                ss.Reconnect();
                    //                disconnectNeeded = true;
                    //            }
                    //            ss.Refresh(ss.Get(_parent.GetType(), ((Core.Bll.IBusinessObjectBase)_parent).GetPropertyValue<Guid>("Id")));
                    //        }
                    //    }
                    //}
                }
                if (ss is Session && ((Session)ss).AfterRefresh != null)
                {
                    ((Session)ss).AfterRefresh(this, EventArgs.Empty);
                }
                if (disconnectNeeded)
                    ss.Disconnect();
            }
        }

        public delegate void AfterRefreshEventDelegate(Core.Dal.ISession sender, EventArgs e);

        public event AfterRefreshEventDelegate AfterRefresh;

        private void FlushAndClearDirty()
        {
            NHibernate.ITransaction tx = null;
            try
            {
                // Izmanto DB tranzakciju
                tx = _hSession.BeginTransaction();
                // Te notiek flush's. Interceptorā uzkrāju visu mainīto sessijas objektu sarakstu
                tx.Commit(); // implies _hSession.Flush(); 
            }
            catch (Exception ex)
            {
                if (tx != null) tx.Rollback();
                this.RecoverSession(ex);
                throw;
            }

            foreach (object obj in _interceptor.FlushedEntities.Keys)
            {
                // Noņem Dirty
                if (obj is ITracksDirty)
                    ((ITracksDirty)obj).IsDirty = false;
            }
        }

        private void RecoverSession(Exception ex)
        {
            if (ex is NHibernate.StaleObjectStateException)
            {
                throw new TpaisException(ErrMsg.GetText(Msg.StaleObject));
            }
            try
            {
                // Izveido jaunu sessiju un kopē interceptora sakrātos objektus uz turieni
                NHibernate.ISession newSession = _hSession.SessionFactory.OpenSession(_interceptor);
                Manager.Instance.UnregisterSessionWrapper(_hSession);
                _hSession.Close();

                foreach (object obj in _interceptor.FlushedEntities.Keys)
                    newSession.Replicate(obj, NHibernate.ReplicationMode.Ignore);

                _hSession = newSession;
                Manager.Instance.RegisterSessionWrapper(_hSession, this);
            }
            catch (Exception exAgain)
            {
                throw new CriticalException(new StringBuilder(exAgain.Message).Append(" during RecoverSession (see inner exception for previous exception)").ToString() + ex.ToString(), ex);
            }
        }

        void ISession.Rollback()
        {
            _hSession.Close();
        }

        #endregion
    }
}
