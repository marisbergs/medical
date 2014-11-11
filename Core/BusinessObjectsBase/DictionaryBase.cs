using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Bll
{
    [Serializable]
    public class DictionaryBase<IdType> : BusinessObjectBase<IdType>, Core.Dal.ISynchronizesSeparately
        where IdType : IComparable<IdType>
    {
        protected string _value;

        public virtual string Value
        {
            get
            {
                return _value;
            }
            set
            {
                Assign("Value", value, ref _value);
            }
        }

        public override string ToString()
        {
            if (_value == null)
            {
                return "";
            }
            else
            {
                return _value;
            }
        }

        protected DictionaryBase()
        {
        }

        protected DictionaryBase(Core.Dal.ISession session)
            : base(session)
        {
        }
    }
}
