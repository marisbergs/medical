using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;


namespace Core.UI
{
    /// <summary>
    /// Helper functions to deal with binding information
    /// </summary>
    public static class BindingHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="control"></param>
        /// <param name="propertyName"></param>
        /// <param name="isCollection"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static Type BoundTypeFinder(Control control, string propertyName, out bool isCollection)
        {
            isCollection = false;

            // Look for bindings
            Binding b = control.DataBindings[propertyName];
            if (b == null) return null;

            // Extract data source type

            object dataSource = b.DataSource;

            // Skip thru the BindingSource
            if (dataSource is BindingSource)
            {
                BindingSource bs = (dataSource as BindingSource);
                if (bs.DataMember == "")
                {
                    dataSource = bs.DataSource;
                }
                else
                {
                    dataSource = ReflectionHelper.GetPropertyValue(bs.DataSource, bs.DataMember);
                }
            }

            // Get the underlying type of data source
            // While nothing is assigned to BindingSource's datasource, it is the Type of single item
            Type dataSourceType = (dataSource is Type) ? (Type)dataSource : dataSource.GetType();
            
            // First try if it is a icollection<t> (only generic collections are supported)
            Type dataSourceMemberType = ReflectionHelper.GetGenericCollectionMemberType(dataSourceType);
            if (dataSourceMemberType == null)
            {
                // Was not an icollection<t>, so we assume that it is a single object
                dataSourceMemberType = dataSourceType;
            }

            // Now check if bound member is a collection
            Type result = ReflectionHelper.GetPropertyType(dataSourceMemberType, b.BindingMemberInfo.BindingMember);

            Type singleResult = ReflectionHelper.GetGenericCollectionMemberType(result);

            if (singleResult != null)
            {
                // Was a collection
                isCollection = true;
                return singleResult;
            }
            else
            {
                // Was not a collection
                return result;
            }
        }
    }
}
