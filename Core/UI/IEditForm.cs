using System;
using System.Collections.Generic;
using System.Text;
using Core.Dal;
using System.Windows.Forms;
using Core;

namespace Core.UI
{
    public interface IEditForm
    {
        Dictionary<Type,Guid> DataIDs { get;set;}
        System.Collections.IList  DataList { get;set;}
    }
}
