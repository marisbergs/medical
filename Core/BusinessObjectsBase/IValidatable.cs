using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Bll
{
    public interface IValidatable
    {
        /// <summary>
        /// is record valid
        /// </summary>
        bool IsValid { get; }
    }
}
