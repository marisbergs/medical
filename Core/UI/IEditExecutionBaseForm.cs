using System;
using System.Collections.Generic;
using System.Text;

namespace Core.UI
{
    class IEditExecutionBaseForm
    {
        Dictionary<Type, Guid> DataIDs { get;set;}
        System.Collections.IList DataList { get;set;}
    }
}
