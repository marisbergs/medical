using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public interface ILogger
    {
        void Log(Core.Dal.ISession session, System.Guid messageId, params object[] parameters);
        void LogImmediate(System.Guid messageId, params object[] parameters);
    }
}
