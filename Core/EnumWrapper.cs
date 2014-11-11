using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace Core
{
    /// <summary>
    /// Wrapper for enumerations
    /// </summary>
    /// <typeparam name="T">enumeration</typeparam>
    public abstract class EnumWrapper<T> : IComparable
    {
        private T _value;
        /// <summary>
        /// Conained enumeration value
        /// </summary>
        public T Value
        {
            get { return _value; }
            private set { _value = value; _currentTranslation = null; }
        }

        /// <summary>
        /// Unlocalized string value of contained enum value
        /// </summary>
        public string StringValue
        {
            get
            {
                return Converter.ConvertToString(_value);
            }
            set
            {
                _value = (T)Converter.ConvertFromString(value);
                _currentTranslation = null;
            }

        }


        /// <summary>
        /// Localized text representation of value
        /// </summary>
        public string Name
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// Cache storage for translation string
        /// </summary>
        protected string _currentTranslation;

        /// <summary>
        /// Localized ToString()
        /// </summary>
        /// <returns>Localized text representation</returns>
        public override string ToString()
        {
            if (_currentTranslation == null)
            {
                // Dictionary prefix will be type name OR enumeration name if the type is EnumWrapper<T>
                string typePrefix = this.GetType().Name;
                if (typePrefix.StartsWith("EnumWrapper"))
                    typePrefix = typeof(T).Name;
                string dictionaryKey = new StringBuilder(typePrefix).Append(".").Append(_value.ToString()).ToString();
                _currentTranslation = Core.Localization.Instance.TranslateWithDefault(dictionaryKey, _value.ToString());
            }
            return _currentTranslation;
        }

        /// <summary>
        /// Constructor that wraps specific value
        /// </summary>
        /// <param name="value">Value to wrap</param>
        public EnumWrapper(T value)
        {
            _value = value;
            _currentTranslation = null;
        }

        public void SetFormatedValue(string val)
        {
            _currentTranslation = val;
        }

        /// <summary>
        /// Parameterless default constructor
        /// </summary>
        public EnumWrapper()
        {
            _value = default(T);
            _currentTranslation = "";
        }

        private int _intValue;
        public int IntValue
        {
            get { return _intValue; }
            set { _intValue = value; }
        }

        /// <summary>
        /// Lazy initialized IList that could be used in pickers
        /// </summary>
        protected static System.Collections.IList _listHolder = null;

        /// <summary>
        /// Property to use as a binding source for value pickers
        /// </summary>
        public static System.Collections.IList ListSource
        {
            get
            {
                if (_listHolder == null)
                {
                    _listHolder = new System.Collections.ArrayList();
                    // Default implementation: build a list from enumeration
                    foreach (T value in Enum.GetValues(typeof(T)))
                    {
                        _listHolder.Add(value);
                    }
                }
                return _listHolder;
            }
        }

        /// <summary>
        /// Lazy initialized enum converter
        /// </summary>
        private static EnumConverter _converter;
        private static EnumConverter Converter
        {
            get
            {
                if (_converter == null)
                {
                    _converter = (EnumConverter)TypeDescriptor.GetConverter(typeof(T));
                }
                return _converter;
            }
        }



        public static bool operator ==(EnumWrapper<T> op1, EnumWrapper<T> op2)
        {
            if ((object)op1 == null) return (object)op2 == null;
            return op1.Equals (op2);
        }

        public static bool operator !=(EnumWrapper<T> op1, EnumWrapper<T> op2)
        {
            return !(op1 == op2);
        }

        public override bool Equals(object obj)
        {
            EnumWrapper<T> otherObj = obj as EnumWrapper<T>;
            if ((object)otherObj == null)
                return false;
            return this.Value.Equals (otherObj.Value);
        }

        public override int GetHashCode()
        {
            return this.Value.GetHashCode();
        }

        #region IComparable Members

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }
            else
            {
                return this.ToString().CompareTo(obj.ToString());
            }
        }

        #endregion
    }
}
