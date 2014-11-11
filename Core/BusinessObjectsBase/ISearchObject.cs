using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Bll
{
    public interface ISearchObject
    {
        IList<Core.Dal.Expressions.CriterionBase> BuildCriteria();
        void ResetValues(Core.Dal.ISession session);
    }
}
