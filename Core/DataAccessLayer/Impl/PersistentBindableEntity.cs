using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;
using System.Xml.Serialization;
using System.Collections;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Core.Dal
{
    public class PersistentBindableEntity : ITracksDirty, INotifyPropertyChanged, IProvidesSession, NHibernate.ILifecycle, ISynchronizable //NHibernate.ILifecycle
    {
        #region ITracksDirty Members

        /// <summary>
        /// Pazīme, ka ierasksts ir jāsaglabā pie Flush().
        /// </summary>
        protected bool _isDirty;
        protected bool _syncRoot = false;

        [XmlIgnore]
        public bool IsDirty
        {
            get { return _isDirty; }
            set
            {
                if (_isDirty != value)
                {                    
                    _isDirty = value;
                    if (value && (this is IHasParent))
                    {
                        ITracksDirty parent = ((this as IHasParent).Parent as ITracksDirty);
                        if (parent != null)
                            parent.IsDirty = true;
                    }
                    OnPropertyChanged("IsDirty");
                }
            }
        }

        #endregion

        #region INotifyPropertyChanged

        /// <summary>
        /// PropertyChanged event is fired whenever a property of an object is changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Wrapperis <seealso cref="PropertyChanged"/> eventa izšaušanai.
        /// Pie viena arī uzstāda IsDirty pazīmi.
        /// </summary>
        /// <param name="propertyName"></param>
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));

            // Set IsDirty
            if (propertyName != "IsDirty")
            {
                // Try to distinct cases where setting of IsDirty is not appropriate
                // Currently ReadOnly property (or property with non-public setters) value changes are filtered out
                // TODO: Probably NHibernate metadata could be used...
                PropertyInfo pi = Core.ReflectionHelper.LocateProperty(this.GetType(), propertyName, BindingFlags.Instance | BindingFlags.Public);
                if (pi != null && pi.CanWrite && pi.GetSetMethod() != null)
                {
                    IsDirty = true;
                }
            }
        }

        #endregion

        #region IProvidesSession Members

        private ISession _session = null;

        /// <summary>
        /// Atdod vai nu savu sessiju, vai jaunu, ja savas nav.
        /// </summary>
        /// <returns></returns>
        public ISession GetSession()
        {
            if (_session == null || !_session.IsOpen)
                return Manager.Instance.OpenSession();
            if (!_session.IsConnected)
                _session.Reconnect();
            return _session;
        }

        public void SetSession(ISession session)
        {
            _session = session;
        }

        #endregion

        /// <summary>
        /// Called when a new object is added to session (INSERT will be performed on commit)
        /// </summary>
        /// <remarks>You can use this method to do some logging</remarks>
        protected virtual void OnSaveNew()
        {
        }

        #region ILifecycle Members
        // Izmantojam NHibernate.ILifecycle, lai uzstādītu sessiju, un noņemtu _isDirty pie load'a.
        NHibernate.LifecycleVeto NHibernate.ILifecycle.OnSave(NHibernate.ISession s)
        {
            _session = Manager.Instance.GetSessionWrapper(s);
            OnSaveNew();
            return NHibernate.LifecycleVeto.NoVeto;
        }

        NHibernate.LifecycleVeto NHibernate.ILifecycle.OnUpdate(NHibernate.ISession s)
        {
            _session = Manager.Instance.GetSessionWrapper(s);
            return NHibernate.LifecycleVeto.NoVeto;
        }

        NHibernate.LifecycleVeto NHibernate.ILifecycle.OnDelete(NHibernate.ISession s)
        {
            _session = null;
            return NHibernate.LifecycleVeto.NoVeto;
        }

        void NHibernate.ILifecycle.OnLoad(NHibernate.ISession s, object id)
        {
            _session = Manager.Instance.GetSessionWrapper(s);
            _isDirty = false;
        }

        #endregion

        private Int32 _lockVersion;

        #region ISynchronizable Members

        private DateTime _updateTime;

        public virtual DateTime UpdateTime
        {
            get { return _updateTime; }
        }

        private int _version = 0;

        [XmlIgnore]
        public virtual int Version
        {
            get { return _version; }
            set { _version = value; }
        }

        private Guid? _source;

        [XmlIgnore]
        public virtual Guid? Source
        {
            get { return _source; }
            set { _source = value; }
        }

        //public static TextWriter debugLog = new FileStream ( "c:\sync.txt", FileMode.OpenOrCreate );
        public virtual void CollectChangedItems(System.Collections.Queue items, Expressions.CriterionBase condition, bool stopAtFirst, ArrayList syncRootObjects)
        {
            Application.DoEvents();            
            if (items.Contains(this) || syncRootObjects.Contains (this))
            {
                // Already processed
                return;
            }
            syncRootObjects.Add(this);
            Type myType = this.GetType();
            NHibernate.Persister.Entity.IEntityPersister ep = (_session.SessionFactory as NHibernate.Engine.ISessionFactoryImplementor).GetEntityPersister(this.GetType());
            Debug.WriteLine (this.GetType ().Name +": " +  this.ToString () + " {");
            // Myself and items I depend on
            if (condition.EvaluateFor(this))
            {

                if (stopAtFirst)
                {
                    // Shortcut
                    syncRootObjects.Remove(this);
                    items.Enqueue(this);
                    return;
                }

                // Go thru associations that are references to outside
                for (int i = 0; i < ep.PropertyTypes.Length; ++i)
                {
                    NHibernate.Type.IAssociationType t = (ep.PropertyTypes[i] as NHibernate.Type.IAssociationType);
                    if (t != null && t.ForeignKeyDirection == NHibernate.Type.ForeignKeyDirection.ForeignKeyFromParent)
                    {
                        if (ep.PropertyNames[i] == "ViolationId" || ep.PropertyNames[i] == "CMCaseDocuments")
                        {

                        }
                        // Do not synchronize if member has an interface ISynchronizesSeparately
                        PropertyInfo pi = ReflectionHelper.LocateProperty(myType, ep.PropertyNames[i], BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                        if (pi.PropertyType.GetInterface(typeof(ISynchronizesSeparately).Name) == null)
                        {
                            object r = pi.GetValue(this, null);
                            if (r != null && !this.Equals(r) && !items.Contains(r))
                            {
                                if (ep.PropertyCascadeStyles[i] != NHibernate.Engine.Cascades.CascadeStyle.StyleNone)
                                {
                                    if (r is ISynchronizable)
                                    {
                                        NHibernate.NHibernateUtil.Initialize(r);
                                        (r as ISynchronizable).CollectChangedItems(items, condition, stopAtFirst, syncRootObjects);
                                    }
                                    else
                                    {
                                        // Copy cascaded objects always if not ISynchronizable
                                        NHibernate.NHibernateUtil.Initialize(r);
                                        items.Enqueue(r);
                                        Debug.WriteLine(this.GetType().Name + ": " + this.ToString()); ;
                                        if (stopAtFirst) return;
                                    }
                                }
                                else if (r is ISynchronizable && condition.EvaluateFor(r))
                                {
                                    NHibernate.NHibernateUtil.Initialize(r);
                                    (r as ISynchronizable).CollectChangedItems(items, condition, stopAtFirst, syncRootObjects);
                                }
                            }
                        }
                    }
                }
                syncRootObjects.Remove(this);
                items.Enqueue(this);
            }

            // Now go thru dependant objects
            for (int i = 0; i < ep.PropertyTypes.Length; ++i)
            {
                NHibernate.Type.IAssociationType t = (ep.PropertyTypes[i] as NHibernate.Type.IAssociationType);
                if (t != null && t.ForeignKeyDirection == NHibernate.Type.ForeignKeyDirection.ForeignKeyToParent)
                {
                    if (ep.PropertyCascadeStyles[i] != NHibernate.Engine.Cascades.CascadeStyle.StyleNone)
                    {
                        if (ep.PropertyNames[i] == "ViolationId" || ep.PropertyNames[i] == "CMCaseDocuments")
                        {
                            
                        }
                        PropertyInfo pi = ReflectionHelper.LocateProperty(myType, ep.PropertyNames[i], BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                        Type collectionMemberType = ReflectionHelper.GetGenericCollectionMemberType(pi.PropertyType);
                        if (collectionMemberType != null)
                        {
                            if (collectionMemberType.GetInterface(typeof(ISynchronizesSeparately).Name) == null)
                            {
                                System.Collections.IList children = (pi.GetValue(this, null) as System.Collections.IList);
                                if (children != null)
                                {
                                    foreach (object child in children)
                                    {
                                        if (child is ISynchronizable)
                                        {
                                            NHibernate.NHibernateUtil.Initialize(child);
                                            (child as ISynchronizable).CollectChangedItems(items, condition, stopAtFirst, syncRootObjects);
                                        }
                                        else
                                        {
                                            NHibernate.NHibernateUtil.Initialize(child);
                                            items.Enqueue(child);
                                            Debug.WriteLine(this.GetType().Name + ": " + this.ToString()); ;
                                        }
                                        if (stopAtFirst && items.Count > 0) return;
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (pi.PropertyType.GetInterface(typeof(ISynchronizesSeparately).Name) == null)
                            {
                                object child = pi.GetValue(this, null);
                                if (child != null)
                                {
                                    if (child is ISynchronizable)
                                    {
                                        NHibernate.NHibernateUtil.Initialize(child);
                                        (child as ISynchronizable).CollectChangedItems(items, condition, stopAtFirst, syncRootObjects);
                                    }
                                    else
                                    {
                                        NHibernate.NHibernateUtil.Initialize(child);
                                        items.Enqueue(child);
                                        Debug.WriteLine(this.GetType().Name + ": " + this.ToString()); ;
                                    }
                                    if (stopAtFirst && items.Count > 0) return;
                                }
                            }
                        }
                    }
                }
                
            }
            Debug.WriteLine("}");            
        }

        #endregion

        /// <summary>
        /// Creates an instance of <seealso cref="PersistentBindableEntity"/>
        /// </summary>
        protected PersistentBindableEntity()
        {
            _isDirty = true;
            // HACK: Lai apietu problēmas dēļ neizmainītiem konstruktoriem mantiniekos
            _updateTime = DateTime.Now;
        }

        /// <summary>
        /// Creates an new instance of <seealso cref="PersistentBindableEntity"/>
        /// that is going to be attached to given <paramref name="session"/>
        /// </summary>
        /// <param name="session">Session that will be used to persist given instance</param>
        protected PersistentBindableEntity(ISession session)
            : this()
        {
            _session = session;
            _updateTime = DateTime.Now;
        }


        #region ITouchable Members

        public virtual void Touch()
        {
            // this public method is called just to initialize the object;
        }

        #endregion
    }

}
