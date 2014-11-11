using System;
using System.Collections;
using System.Text;

namespace Core.Dal
{
    public interface IInterceptor : NHibernate.IInterceptor
    {
        IDictionary FlushedEntities { get; }
    }
}
