using System;
using System.Collections;
using System.ComponentModel;
using System.Text;
using Core.Dal;

namespace Core.Bll
{
    public interface IBusinessObjectBase : IValidatable
    {
        /// <summary>
        /// Get given property value
        /// </summary>
        TP GetPropertyValue<TP>(string propertyName);

        /// <summary>
        /// Validate object
        /// </summary>
        Core.Result Validate();

        /// <summary>
        /// Validate given propertu
        /// </summary>
        Core.Result ValidateProperty(string propertyName);

        /// <summary>
        /// for record delete set active to false
        /// </summary>
        bool IsActive { get;set; }
    

        /// <summary>
        /// Delete reason
        /// </summary>
        string DeleteNotes { set;}

        /// <summary>
        /// for object type
        /// </summary>
        Object Object { get;}

    }
}
