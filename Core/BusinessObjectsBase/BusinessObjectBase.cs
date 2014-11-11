using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.ComponentModel;
using System.Reflection;
using Core.Dal;
using Core.Dal.Expressions;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Core.Bll
{

    public abstract class SolidBusinessObjectBase
    {
    }

    public class PermissionsChecker
    {
        public static IDictionary Permissions;
        public static bool CanDo(string actionName)
        {
            if (Permissions == null)
                return false;
            else
             return Permissions.Contains(actionName);
        }
    }
    /// <summary>
    /// Base class for all application entities
    /// </summary>
    /// <typeparam name="IdType">Type used as a key to identify objects. Id property of an object is of type IdType</typeparam>
    [Serializable]
    public abstract class BusinessObjectBase<IdType> : PersistentBindableEntity
        , IDataErrorInfo, IBusinessObjectBase, IComparable, IConstrained
            where IdType : IComparable<IdType>
    {
        protected Validator Validator;
 
        /// <summary>
        /// Performs a security check for a given action. If current user role allows to perform the action it returns true, otherwise it returns false
        /// </summary>
        /// <param name="actionName">name of the action</param>
        /// <returns></returns>
        public static bool CanDo(string actionName)
        {
            return PermissionsChecker.CanDo(actionName);
        }


        private void CommonInit()
        {
            Validator = new Validator(this);
        }
       
        protected BusinessObjectBase()
        {
            CommonInit();
        }

        protected BusinessObjectBase(ISession session) : base(session)
        {
            CommonInit();
        }

        public TP GetPropertyValue<TP>(string propertyName)
        {            
            PropertyInfo pi = ReflectionHelper.LocateProperty(this.GetType(),propertyName,BindingFlags.Instance|BindingFlags.Public);
            if (pi == null) return default(TP);
            return (TP)pi.GetValue(this, null);            
        }

        

        public Result Validate()
        {
            return Validator.Validate();
        }
        
        public Result ValidateProperty(string propertyName)
        {
            return Validator.ValidateProperty(propertyName);
        }

        public virtual bool IsValid
        {
            get { return !Validate().HasErrors; }
        }

        /// <summary>
        /// Method used instead of standard assignment operator in setter properties of an object. Fires propertyChanged events, performs validation checks, maintains IsDirty flag.
        /// </summary>
        /// <typeparam name="PropertyType">type of the property to be assigned to (current property type).</typeparam>
        /// <param name="propertyName">name of the property to be assigned to (current property).</param>
        /// <param name="value">new value to be assigned</param>
        /// <param name="member">member field name in which the actual property value is strored</param>
        /// <returns>false if property value did not change, true otherwise</returns>
        protected virtual bool Assign<PropertyType>(string propertyName, PropertyType value, ref PropertyType member)
        {
            if (member != null)
            {
                if (member.Equals(value)) return false;
            }
            member = value;

            if (typeof(PropertyType).Name == "IChildCollection`1" && (member as IHasParent) != null)
            {
                ((IHasParent)member).Parent = this;
            }

            OnPropertyChanged(propertyName);

            return true;
        }

      

        public virtual object Object
        {
            get
            {
                return this;
            }            
        }



        IdType _id;
        public virtual IdType Id
        {
            get { return _id; }
            set { Assign("Id", value, ref _id); }
        }

        bool _selected;
        [XmlIgnore]
        public virtual bool Selected
        {
            get { return _selected; }
            set
            { Assign("Selected", value, ref _selected); }
        }
      
        private DateTime? _deleteTime;
        [XmlIgnore]
        public virtual DateTime? DeleteTime
        {
            get { return _deleteTime; }
            private set { Assign("DeleteTime", value, ref _deleteTime); }
        }

        private String _deleteNotes;
        /// <summary>
        /// Dzēšanas pamatojums
        /// </summary>
        public virtual String DeleteNotes
        {
            get { return _deleteNotes; }
            set { Assign("DeleteNotes", value, ref _deleteNotes); }
        }

        [XmlIgnore]
        public virtual Boolean IsActive
        {
            get { return DeleteTime == null; }
            set
            {
                if (value == false&&!CanDelete  )                
                {
                    throw new CriticalException(Core.ErrMsg.GetText(Msg.NoPermissionToDelete));
                }

                // "Make inactive" == "delete"
                if (value != IsActive)
                {
                    if (value)
                        Assign<DateTime?>("DeleteTime", null, ref _deleteTime);
                    else
                    {
                        CascadeDelete();
                        Assign<DateTime?>("DeleteTime", DateTime.Now, ref _deleteTime);
                    }
                    // Reports "PropertyChanged" for IsActive
                    OnPropertyChanged("IsActive");
                }
            }
        }
        /// <summary>
        /// Override this to delete (set IsActive, DeleteNotes) child objects
        /// </summary>
        protected virtual void CascadeDelete()
        {
        }

        /// <summary>
        /// Use this to delete (set IsActive, DeleteNotes) child object or collection
        /// </summary>
        /// <param name="member">child or child collection to delete</param>
        protected virtual void DeleteChild(object member)
        {
            if (member is IList)
            {
                DeleteChildCollection(member as IList);
            }
            else if (member is IBusinessObjectBase)
            {
                IBusinessObjectBase bob = (member as IBusinessObjectBase);
                bob.DeleteNotes = this.DeleteNotes;
                bob.IsActive = false;
            }
        }

        private void DeleteChildCollection(IList iList)
        {
            if (iList != null)
            {
                foreach (object o in iList)
                {
                    DeleteChild(o);
                }
            }
        }

        public override bool Equals(object obj)
        {
            BusinessObjectBase<IdType> otherObj = obj as BusinessObjectBase<IdType>;
            if (otherObj == null) return false;

            if ((Id == null) && (otherObj.Id == null))
                return obj == (object)this;

            if (Id == null)
                return false;

            if ((Id.CompareTo(default(IdType)) == 0) && (otherObj.Id.CompareTo(default(IdType)) == 0))
                return obj == (object)this;
            
            return Id.CompareTo(otherObj.Id) == 0;
        }

        public override int GetHashCode()
        {
            return (GetType().Name + Id.ToString()).GetHashCode();
        }

        #region IDataErrorInfo Members

        [Browsable(false)]
        public virtual string Error
        {
            get 
            {
                return Validator.Validate().ErrorString;
            }
        }

        public virtual string this[string columnName]
        {
            get 
            {
                 return Validator.ValidateProperty(columnName).ErrorString;
            }
        }

        #endregion

        #region DAO methods

        //public static IList<ObjectType> GetEntities(IDao dao, params CriterionBase[] additionalCriteria)
        //{
        //    if (compulsoryCriterion == null)
        //    {
        //        return dao.GetFilteredObjects<ObjectType>(additionalCriteria);
        //    }
        //    else
        //    {
        //        CriterionBase[] arr = new CriterionBase[additionalCriteria.Length + 1];
        //        additionalCriteria.CopyTo(arr, 1);
        //        arr[0] = compulsoryCriterion;
        //        return dao.GetFilteredObjects<ObjectType>(arr);
        //    }
        //}



        public virtual Result Save()
        {
            GetSession().SaveOrUpdate(this);
            return new Result();
        }

        #endregion


        #region IComparable Members

        public int CompareTo(object obj)
        {
            return this.ToString().CompareTo(obj.ToString());
        }

        #endregion



        #region Reporting
        public virtual string XI(string path)
        {
            object o = ReflectionHelper.GetPropertyValue(this, path);
            if (o == null) return "x";//"<no value!!!>";
            if (o is bool)
            {
                return (bool)o ? Helper.RtfTrueTableTick() : "";
            }
            return Helper.ToRtfString(o.ToString());
        }

        public virtual string RI(string path)
        {
            object o = ReflectionHelper.GetPropertyValue(this, path);
            if (o is string)
            {
                if (string.IsNullOrEmpty((string)o)) return "";//"<no value!!!>";
            }
            if (o == null) return "";//"<no value!!!>";
            if (o is bool)
            {
                return (bool)o ? Helper.RtfTrueTick() : Helper.RtfFalseTick();
            }
            return Helper.ToRtfString(o.ToString());
        }

       /// <summary>
       /// Formating with lover case
       /// </summary>
        public virtual string RIL(string path)
        {
            object o = ReflectionHelper.GetPropertyValue(this, path);
            if (o is string)
            {
                if (string.IsNullOrEmpty((string)o)) return "";//"<no value!!!>";
            }
            if (o == null) return "";//"<no value!!!>";
            if (o is bool)
            {
                return (bool)o ? Helper.RtfTrueTick() : Helper.RtfFalseTick();
            }
            return Helper.ToRtfString(o.ToString().ToLower());
        }

        /// <summary>
        /// Return empti string if value is null
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public virtual string RIN(string path)
        {
            object o = ReflectionHelper.GetPropertyValue(this, path);
            if (o is string)
            {
                if (string.IsNullOrEmpty((string)o)) return "";//"<no value!!!>";
            }
            if (o == null) return "";//"<no value!!!>";
            if (o is bool)
            {
                return (bool)o ? Helper.RtfTrueTick() : Helper.RtfFalseTick();
            }
            return Helper.ToRtfString(o.ToString());
        }

        public virtual string BI(string path)
        {
            object o = ReflectionHelper.GetPropertyValue(this, path);
            if (o == null) return Helper.RtfNothingTick();//"<no value!!!>";
            if (o is bool)
            {
                return (bool)o ? Helper.RtfTrueTick() : Helper.RtfFalseTick();
            }
            return Helper.ToRtfString(o.ToString());
        }

        public virtual string BTF(string path)
        {
            object o = ReflectionHelper.GetPropertyValue(this, path);
            if (o == null) return "";//"<no value!!!>";
            if (o is bool)
            {
                return (bool)o ? Helper.RtfTrueTableTick() : Helper.RtfFalseTableTick();
            }
            return Helper.ToRtfString(o.ToString());
        }


        public virtual object OI(string path)
        {
            object o = ReflectionHelper.GetPropertyValue(this, path);
            return o;
        }

        public virtual string S(string path)
        {
            object o = ReflectionHelper.GetPropertyValue(this, path);
            if (o == null) return "";
            return X(o.ToString());
        }

        public virtual string F(string path, string format)
        {
            IFormattable o = ReflectionHelper.GetPropertyValue(this, path) as IFormattable;
            if (o == null) return "";
            return X(o.ToString(format, null));
        }

        public virtual object D(string path)
        {
            return X(this.F(path, "yyyy-MM-dd"));
        }

        public virtual object DAT(string path, string format, bool empty)
        {
            Object o = ReflectionHelper.GetPropertyValue(this, path) as IFormattable;
            if ((format == "Gen") || (format == "Dat") || (format == "Lok") || (format == "Aku"))
                {
                if ((o != null) && (o is DateTime))
                {
                    DateTime Dat = (DateTime)Convert.ChangeType(o, typeof(DateTime));
                    String ResultDate = Dat.Year.ToString() + "." +
                        Core.Localization.Instance.Translate("Date.Year") +
                        " " + Dat.Day.ToString() + "." +
                        Core.Localization.Instance.Translate("Date." + Dat.Month.ToString() + "." + format);
                    return Helper.ToRtfString(ResultDate);
                }
                else
                {
                    if (empty == true)
                    {
                        DateTime CurrentDate = DateTime.Now;
                        bool ShowMonth = true;
                        int RestWorkDays = System.DateTime.DaysInMonth(CurrentDate.Year, CurrentDate.Month) - CurrentDate.Day;
                        //if ((CurrentDate.DayOfWeek == DayOfWeek.Wednesday) || (CurrentDate.DayOfWeek == DayOfWeek.Thursday) || (CurrentDate.DayOfWeek == DayOfWeek.Friday))
                        //{
                        //    RestWorkDays = RestWorkDays - 2;
                        //}
                        if (RestWorkDays < 3) 
                        {
                            ShowMonth = false;
                        }
                        String ResultDate  = "";
                        if (CurrentDate.Month == 12)
                        {
                            ResultDate = "          ";
                        }
                        else
                        {
                            ResultDate = CurrentDate.Year.ToString();
                        }
                        ResultDate = ResultDate + "." + Core.Localization.Instance.Translate("Date.Year") + "      .";
                        if (ShowMonth == true)
                        {
                            ResultDate = ResultDate + Core.Localization.Instance.Translate("Date." + CurrentDate.Month.ToString() + "." + format);
                        }
                        return Helper.ToRtfString(ResultDate);
                    }
                }
            }
            return Helper.ToRtfString("");
        }

        public virtual object FT(string path)
        {            
            if (S(path)=="True")
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public virtual object N(string path)
        {
            return S(path).Replace(",", ".");
        }
        public virtual string FI(string path, string format)
        {
            IFormattable o = ReflectionHelper.GetPropertyValue(this, path) as IFormattable;
            if (o == null) return "";
            return Helper.ToRtfString(o.ToString(format, null));
        }
        public virtual string FF(decimal value, string format)
        {
            IFormattable o = value as IFormattable;
            if (o == null) return "";
            return Helper.ToRtfString(o.ToString(format, null));
        }

        /// <summary>
        /// Return empti string if value is null
        /// </summary>
        public virtual string FIN(string path, string format)
        {
            IFormattable o = ReflectionHelper.GetPropertyValue(this, path) as IFormattable;
            if (o == null) return "";
            return Helper.ToRtfString(o.ToString(format, null));
        }

        private static string X(string input)
        {
            return input.Replace("&", "&amp;").Replace("<", "&lt;");
        }
        
        
        public virtual string EnumTick(string path, string value)
        {
            object o = ReflectionHelper.GetPropertyValue(this, path);
            if (o == null) return "";//"<no value!!!>";
            return o.ToString() == value ? Helper.RtfTrueTick () : Helper.RtfFalseTick ();
        }

        public virtual string BooleanTick(string path, string value)
        {
            object o = ReflectionHelper.GetPropertyValue(this, path);
            if (o == null) return "";//"<no value!!!>";
            return o.ToString().ToUpper() == value.ToUpper() ? Helper.ToRtfString(ErrMsg.GetText("YesNo", "Yes")) : Helper.ToRtfString(ErrMsg.GetText("YesNo", "No"));
        }
        #endregion


        #region IConstrained Members

        public virtual bool CanSee
        {
            get { return true; }
        }

        public virtual bool CanSave
        {
            get { return true; }
        }


        public virtual  bool CanDelete
        {
            get { return IsActive; }
        }

        public virtual bool CanEdit
        {
            get { return IsActive; }
        }
        #endregion

        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            switch (propertyName)
            {
                case "IsActive":
                    this.OnPropertyChanged("CanEdit");
                    this.OnPropertyChanged("CanDelete");
                    break;
            }

        }
    }
}
