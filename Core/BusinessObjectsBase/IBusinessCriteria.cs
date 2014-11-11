using System;
using System.Collections.Generic;
using System.Text;
using NHibernate.Expression;
using NHibernate;

namespace Core.Bll
{
    public interface IBusinessCriteria
    {
        void Apply(ICriteria ic);
    }
}
