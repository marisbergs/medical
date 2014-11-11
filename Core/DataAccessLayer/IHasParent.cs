using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Dal
{
    public interface IHasParent
    {
        object Parent { get; set; }
    }
}
