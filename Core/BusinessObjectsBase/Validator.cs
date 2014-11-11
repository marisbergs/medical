using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace Core.Bll
{
    public delegate Result RulePredicate ( IBusinessObjectBase obj, params object [] parameters );
    

    [Serializable]
    public class Validator
    {
        
        struct BusinessRule
        {
            public RulePredicate _rulePredicate;
            public object[] _parameters;
            public BusinessRule(RulePredicate rulePredicate, params object[] parameters)
            {
                _rulePredicate = rulePredicate;
                _parameters = parameters;
            }
            
        }
        
        Dictionary<String, List<BusinessRule>> BusinessRules;
        IBusinessObjectBase ValidatedObject;
        Type ValidatedType;

        public Validator(IBusinessObjectBase validatedObject)
        {            
            BusinessRules = new Dictionary<string, List<BusinessRule>>();
            ValidatedObject = validatedObject;
            ValidatedType = validatedObject.GetType();
        }

        
        public void AddBusinessRule(string propertyName, RulePredicate rulePredicate, params object [] parmeters)
        {
            if (!BusinessRules.ContainsKey(propertyName))
            {
                if (!ReflectionHelper.PropertyExists(ValidatedType,propertyName))
                    throw new Exception("Property " + propertyName + " does not exist in " + ValidatedType.Name);
                BusinessRules.Add(propertyName, new List<BusinessRule>());
            }
            BusinessRules[propertyName].Add(new BusinessRule(rulePredicate, parmeters));
        }

        public Result ValidateProperty(string propertyName)
        {
            Result res = new Result();
            if (!BusinessRules.ContainsKey(propertyName)) return res;
            foreach (BusinessRule br in BusinessRules[propertyName])
            {
                res += br._rulePredicate(ValidatedObject, br._parameters);
            }
            return res;
        }


        public Result Validate()
        {
            Result res = new Result ();
                        
            foreach ( string propertyName in BusinessRules.Keys )
            {
                res += ValidateProperty(propertyName);
            }
            return res;
        }
    }
}
