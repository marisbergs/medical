using System.ComponentModel;
using System.Collections.Generic;
using System;

namespace Core.Bll
{
    public class PropertyComparer<T> : IComparer<T>
    {
        PropertyDescriptor propertyInfo;

        public PropertyComparer(PropertyDescriptor prop)
        {
            if (prop.PropertyType.GetInterface("IComparable") == null)
            {
                throw new Exception("Property " + prop.Name + " not comparable!");
            }
            propertyInfo = prop;
        }

        public int Compare(T x, T y)
        {
            return CompareThem(x, y);
        }

        protected int CompareThem(T x, T y)
        {
            IComparable xValue = propertyInfo.GetValue(x) as IComparable;
            IComparable yValue = propertyInfo.GetValue(y) as IComparable;
            if (xValue == null)
            {
                return (yValue == null) ? 0 : -1;  // NULL's first
            }
            else
            {
                return xValue.CompareTo(yValue);
            }
        }

    }


    public class ReversePropertyComparer<T> : PropertyComparer<T>
    {
        public ReversePropertyComparer(PropertyDescriptor prop) : base(prop)
        {
        }

        public new int Compare(T x, T y)
        {
            return CompareThem(y,x);
        }
    }
}