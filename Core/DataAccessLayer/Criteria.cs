using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Core.Dal.Expressions
{
    public abstract class CriterionBase
    {
        public static CriterionBase And(CriterionBase a, CriterionBase b)
        {
            if (a == null)
                return b;
            if (b == null)
                return a;
            return new And(a, b);
        }
        
        public static CriterionBase operator +(CriterionBase a, CriterionBase b)
        {
            return And(a, b);
        }

        public static CriterionBase operator &(CriterionBase a, CriterionBase b)
        {
            return And(a, b);
        }

        public static CriterionBase Or(CriterionBase a, CriterionBase b)
        {
            if (a == null)
                return b;
            if (b == null)
                return a;
            return new Or(a, b);
        }

        public static CriterionBase operator |(CriterionBase a, CriterionBase b)
        {
            return Or(a, b);
        }

        public abstract bool EvaluateFor(object obj);
        
        public abstract void collectPropertyNames(IDictionary<string,string> names);
    }

    public abstract class UnaryCriterion : CriterionBase
    {
        protected string _propertyName;
        public UnaryCriterion(string propertyName)
        {
            _propertyName = propertyName;
        }

        public string PropertyName
        {
            get
            {
                return _propertyName;
            }
        }

        public override void collectPropertyNames(IDictionary<string, string> names)
        {
            if (!names.ContainsKey(_propertyName))
                names.Add(_propertyName, _propertyName);
        }
    }

    public abstract class BinaryCriterion : UnaryCriterion
    {
        protected object _value;
        public BinaryCriterion(string propertyName, object value) : base(propertyName)
        {
            _value = value;
        }

        public object Value
        {
            get { return _value; }
        }
    }

    public abstract class BinaryLogicalCriterion : CriterionBase
    {
        protected CriterionBase _lhs;
        protected CriterionBase _rhs;
        public BinaryLogicalCriterion(CriterionBase lhs, CriterionBase rhs)
        {
            _lhs = lhs;
            _rhs = rhs;
        }

        public CriterionBase Lhs
        {
            get { return _lhs; }
        }

        public CriterionBase Rhs
        {
            get { return _rhs; }
        }

        public override void collectPropertyNames(IDictionary<string, string> names)
        {
            _lhs.collectPropertyNames(names);
            _rhs.collectPropertyNames(names);
        }
    
    
    }

    public abstract class UnaryLogicalCriterion : CriterionBase
    {
        protected CriterionBase _op;
        public UnaryLogicalCriterion(CriterionBase op)
        {
            _op = op;
        }

        public CriterionBase Op
        {
            get { return _op; }
        }

        public override void collectPropertyNames(IDictionary<string, string> names)
        {
            _op.collectPropertyNames(names);
        }

    }

    public abstract class TertiaryCriterion : UnaryCriterion
    {
        protected object _value1;
        protected object _value2;

        public TertiaryCriterion(string propertyName, object value1, object value2) : base(propertyName)
        {
            _value1 = value1;
            _value2 = value2;
        }

        public object Value1
        {
            get
            {
                return _value1;
            }
        }

        public object Value2
        {
            get
            {
                return _value2;
            }
        }
    }

    public class In : UnaryCriterion
    {
        protected object [] _values;
        public In(string propertyName, params object [] values) : base(propertyName)
        {
            _values = values;
        }

        public object [] Values
        {
            get { return _values; }
        }

        public override bool EvaluateFor(object obj)
        {
            object o = ReflectionHelper.GetPropertyValue(obj, PropertyName);
            if (o == null) return false;

            foreach (object v in Values)
                if (o.Equals(v))
                    return true;

            return false;
        }

    }

    public class NotIn : UnaryCriterion
    {
        protected object[] _values;
        public NotIn(string propertyName, params object[] values)
            : base(propertyName)
        {
            _values = values;
        }

        public object[] Values
        {
            get { return _values; }
        }

        public override bool EvaluateFor(object obj)
        {
            object o = ReflectionHelper.GetPropertyValue(obj, PropertyName);
            if (o == null) return false;

            foreach (object v in Values)
                if (!o.Equals(v))
                    return true;

            return false;
        }

    }

    public class IsNull : UnaryCriterion 
    {
        public IsNull(string propertyName) : base(propertyName) { }
        public override bool EvaluateFor(object obj)
        {
            object o = ReflectionHelper.GetPropertyValue(obj, PropertyName);
            return  (o == null) || (o.ToString().Length == 0);
        }
    }

    public class IsNotNull : UnaryCriterion
    {
        public IsNotNull(string propertyName) : base(propertyName) { }
        public override bool EvaluateFor(object obj)
        {
            object o = ReflectionHelper.GetPropertyValue(obj, PropertyName);
            return !((o == null) || (o.ToString().Length == 0));
        }
    }

    public class NotEq : BinaryCriterion 
    {
        public NotEq(string propertyName, object value) : base(propertyName, value) { }
        public override bool EvaluateFor(object obj)
        {
            object o = ReflectionHelper.GetPropertyValue(obj, PropertyName);
            return (o != null) && (Value != null) && !o.Equals(Value);
        }
    }
    
    public class Eq : BinaryCriterion 
    {
        public Eq(string propertyName, object value) : base(propertyName, value) { }
        public override bool EvaluateFor(object obj)
        {
            object o = ReflectionHelper.GetPropertyValue(obj, PropertyName);
            return (o != null) && (Value != null) && o.Equals(Value);
        }
    }
    public class Ge : BinaryCriterion
    {
        public Ge(string propertyName, object value) : base(propertyName, value) { }
        public override bool EvaluateFor(object obj)
        {
            IComparable o = ReflectionHelper.GetPropertyValue(obj, PropertyName) as IComparable;
            IComparable v = (Value as IComparable);
            if (v == null || o == null) return false;
            return o.CompareTo(v) >= 0;
        }
    }
    public class Le : BinaryCriterion
    {
        public Le(string propertyName, object value) : base(propertyName, value) { }
        public override bool EvaluateFor(object obj)
        {
            IComparable o = ReflectionHelper.GetPropertyValue(obj, PropertyName) as IComparable;
            IComparable v = (Value as IComparable);
            if (v == null || o == null) return false;
            return o.CompareTo(v) <= 0;
        }
    }
    public class Gt : BinaryCriterion
    {
        public Gt(string propertyName, object value) : base(propertyName, value) { }
        public override bool EvaluateFor(object obj)
        {
            IComparable o = ReflectionHelper.GetPropertyValue(obj, PropertyName) as IComparable;
            IComparable v = (Value as IComparable);
            if (v == null || o == null) return false;
            return o.CompareTo(v) > 0;
        }
    }
    public class Lt : BinaryCriterion
    {
        public Lt(string propertyName, object value) : base(propertyName, value) { }
        public override bool EvaluateFor(object obj)
        {
            IComparable o = ReflectionHelper.GetPropertyValue(obj, PropertyName) as IComparable;
            IComparable v = (Value as IComparable);
            if (v == null || o == null) return false;
            return o.CompareTo(v) < 0;
        }
    }
    public class Like : BinaryCriterion 
    {
        public Like(string propertyName, object value) : base(propertyName, value) { }
        public override bool EvaluateFor(object obj)
        {
            String o = ReflectionHelper.GetPropertyValue(obj, PropertyName) as String;
            String v = (Value as String);
            if (v == null || o == null) return false;
            v = v.ToUpper();
            o = o.ToUpper();
            int vl = v.Length;
            if (vl == 0)
                return o.Length == 0;
            if (v[0] == '%' && v[vl - 1] == '%')
                if ( vl == 1 )
                    return true;  // anything that's not NULL likes '%' :)
                else
                    return o.Contains(v.Substring(1,vl-2));
            else if (v[vl - 1] == '%')
                return o.StartsWith(v.Substring(0, vl-1));
            else if (v[0] == '%')
                return o.EndsWith(v.Substring(1, vl-1));
            else
                return o == v;
        }
    }
  
    
    public class Between : TertiaryCriterion 
    {
        public Between(string propertyName, object value1, object value2) : base(propertyName, value1, value2) { }
        public override bool EvaluateFor(object obj)
        {
            IComparable v1 = (Value1 as IComparable);
            IComparable v2 = (Value2 as IComparable);
            IComparable o = (ReflectionHelper.GetPropertyValue(obj, PropertyName) as IComparable);
            if (v1 == null || v2 == null || o == null) return false;
            return o.CompareTo(v1) >= 0 &&  o.CompareTo(v2) <= 0;
        }
    }

    public class Not : UnaryLogicalCriterion
    {
        public Not(CriterionBase op) : base(op) { }
        public override bool EvaluateFor(object obj)
        {
            return !Op.EvaluateFor(obj);
        }
    }
    public class Or : BinaryLogicalCriterion 
    {
        public Or(CriterionBase lhs, CriterionBase rhs) : base(lhs, rhs) { }
        public override bool EvaluateFor(object obj)
        {
            return Lhs.EvaluateFor(obj) || Rhs.EvaluateFor(obj);
        }
    }

    public class And : BinaryLogicalCriterion 
    {
        public And(CriterionBase lhs, CriterionBase rhs) : base(lhs, rhs) { }
        public override bool EvaluateFor(object obj)
        {
            return Lhs.EvaluateFor(obj) && Rhs.EvaluateFor(obj);
        }
    }

    public class Sql : CriterionBase
    {
        private NHibernate.SqlCommand.SqlString _sqlString;

        public NHibernate.SqlCommand.SqlString SqlString
        {
            get { return _sqlString; }
            set { _sqlString = value; }
        }
        private object[] _values;

        public object[] Values
        {
            get { return _values; }
            set { _values = value; }
        }

        private NHibernate.Type.IType[] _types;

        public NHibernate.Type.IType[] Types
        {
            get { return _types; }
            set { _types = value; }
        }

        public Sql(NHibernate.SqlCommand.SqlString sqlString, object[] values, NHibernate.Type.IType[] types)
        {
            _sqlString = sqlString;
            _values = values;
            _types = types;
        }

        public Sql(String sql)
        {
            _sqlString = new NHibernate.SqlCommand.SqlString(new object[] { sql });
            _values = new object[] { };
            _types = new NHibernate.Type.IType[] { };
        }

        public override bool EvaluateFor(object obj)
        {
            return false;
        }

        public override void collectPropertyNames(IDictionary<string, string> names)
        {
        }
    }
  
}
