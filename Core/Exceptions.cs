using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class TpaisException : Exception
    {
        public TpaisException()
        {
        }

        public TpaisException(string message) : base(message)
        {
        }

        public TpaisException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }

    public class CriticalException : TpaisException
    {
        public CriticalException()
        {
        }

        public CriticalException(string message) : base(message)
        {
        }

        public CriticalException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
   
}
