using System.Reflection;
using System;
using System.Collections;
using System.Collections.Generic;
namespace Core
{

    public class ReflectionHelper
    {
        // Cache for last checked type
        private static Type _lastCheckedType = null;
        private static IList _propertiesOfLastCheckedType = new ArrayList();
        /// <summary>
        /// Checks for existence of property with given name in o (if o is System.Type) or in o.GetType()
        /// </summary>
        /// <param name="o">object or Type</param>
        /// <param name="propertyName">Name of the property to check</param>
        /// <returns></returns>
        public static bool PropertyExists(object o, string propertyName)
        {
            Type t = (o is Type) ? (Type)o : o.GetType();
            if (t != _lastCheckedType)
            {
                _lastCheckedType = t;
                _propertiesOfLastCheckedType.Clear();
                PropertyInfo[] props = t.GetProperties();
                foreach (PropertyInfo pi in props)
                {
                    _propertiesOfLastCheckedType.Add(pi.Name);
                }
            }
            return _propertiesOfLastCheckedType.Contains(propertyName);
        }

        public static bool SetPropertyValue(object o, string propertyName, object value)
        {
            PropertyInfo pi = ReflectionHelper.LocateProperty(o.GetType(), propertyName, BindingFlags.Instance|BindingFlags.Public);
            if (pi == null) return false;
            pi.SetValue(o, value, null);
            return true;
        }


        public static void SetProperties(object o, Queue<KeyValuePair<String, Object>> propertyValues)
        {
            if (propertyValues != null)
            {
                foreach (KeyValuePair<String, Object> kvp in propertyValues)
                {
                    SetPropertyValue(o, kvp.Key, kvp.Value);
                }
            }
        }

        /// <summary>
        /// Sets member value using specified propertyPath.
        /// Looks thorough instance fields and properties.
        /// </summary>
        /// <param name="o">object to start with</param>
        /// <param name="propertyPath">member chain to set</param>
        /// <param name="value">value to set</param>
        /// <returns></returns>
        public static bool SetMemberValue(object o, string propertyPath, object value)
        {
            MemberInfo miToAssign=null;
            Object objToAssign=null;
            foreach (string path_item in propertyPath.Split('.'))
            {
                if (o == null) return false;
                FieldInfo fi = o.GetType().GetField(path_item, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                if (fi != null)
                {                    
                    miToAssign = fi;
                    objToAssign = o;
                    o = fi.GetValue(o);
                    continue;
                }
                PropertyInfo pi = o.GetType().GetProperty(path_item, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                if (pi != null)
                {                    
                    miToAssign = pi;
                    objToAssign = o;
                    o = pi.GetValue(o, null);
                    continue;
                }
                return false;
            }

            if (miToAssign is FieldInfo)
            {
                (miToAssign as FieldInfo).SetValue(objToAssign, value);
            }

            if (miToAssign is PropertyInfo)
            {
                (miToAssign as PropertyInfo).SetValue(objToAssign, value,null);
            }

            return true;
        }

        public static object GetPropertyValue(object o, string propertyName)
        {
            PropertyInfo pi;
            if (!string.IsNullOrEmpty(propertyName))
            {
                foreach (string path_item in propertyName.Split('.'))
                {
                    if (o == null) return null;
                    pi = ReflectionHelper.LocateProperty(o.GetType(), path_item, BindingFlags.Instance | BindingFlags.Public);
                    if (pi == null) return null; // No such property
                    o = pi.GetValue(o, null);
                }
                return o;
            }
            return null;
        }

        public static Type GetPropertyType(Type root, string path)
        {
            PropertyInfo pi;
            foreach (string path_item in path.Split('.'))
            {
                pi = root.GetProperty(path_item);
                if (pi == null) return null;
                root = pi.PropertyType;
            }
            return root;
        }

        public static object FindStaticPropertyValue(Type t, string propertyName)
        {
            PropertyInfo pi = LocateProperty(t, propertyName, BindingFlags.Public | BindingFlags.Static);
            if (pi != null)
                return pi.GetValue(null, null);
            else
                return null;
        }

        /// <summary>
        /// Recursively searches for given property thru base classes chain
        /// </summary>
        /// <param name="t">type (class) to start with</param>
        /// <param name="propertyName">property to search</param>
        /// <param name="bindingFlags">binding flags</param>
        /// <returns><seealso cref="System.Reflection.PropertyInfo"/> of found property or <c>null</c></returns>
        /// <remarks>
        /// For things to work correctly you have to choose appropriate binding flags. It is necessary to specify
        /// at least one of <seealso cref="BindingFlags.Instance"/> or <seealso cref="BindingFlags.Static"/>,
        /// and at least one of <seealso cref="BindingFlags.Public"/> or <seealso cref="BindingFlags.NonPublic"/>  
        /// </remarks>
        public static PropertyInfo LocateProperty(Type t, string propertyName, BindingFlags bindingFlags)
        {
            if (t == null)
                return null;

            PropertyInfo pi = t.GetProperty(propertyName, BindingFlags.DeclaredOnly | bindingFlags);
            if (pi != null)
                return pi;

            return LocateProperty(t.BaseType, propertyName, bindingFlags);
        }

        public static MethodInfo LocateMethod(Type t, string methodName, BindingFlags bindingFlags)
        {
            if (t == null)
                return null;

            MethodInfo mi = t.GetMethod(methodName, BindingFlags.DeclaredOnly | bindingFlags);
            if (mi != null)
                return mi;

            return LocateMethod(t.BaseType, methodName, bindingFlags);
        }



        public static Type GetGenericCollectionMemberType(Type genericCollection)
        {
            try
            {
                if (genericCollection.Name == "IChildCollection`1")
                {
                    return genericCollection.GetGenericArguments()[0];
                }
                Type collection = genericCollection.GetInterface("ICollection`1");
                if (collection == null)
                    return null;
                return collection.GetGenericArguments()[0];
            }
            catch (AmbiguousMatchException)
            {
                // TODO: (Low) Handle potential situations when there are more than 1 ICollecton<T> with different T parameter
                throw;
            }
        }

    }
}