using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Core.Bll
{
    public static class CommonBusinessRules
    {

        public static Result CheckEmailFormat(IBusinessObjectBase obj, params object[] parametrs)
        {
            Result res = new Result();
            string propVal = obj.GetPropertyValue<string>((string)parametrs[0]);
            if (string.IsNullOrEmpty(propVal)) return res;
            Regex rgx = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
            if (!rgx.IsMatch(propVal))
            {
                res.HasErrors = true;
                res.Messages.Add(new Message(MessageSeverity.Error, Err.EmailNotValid));
            }
            return res;
        }

        public static Result CheckRequired(IBusinessObjectBase obj, params object[] parameters)
        {
            Result res = new Result();
            if (obj == null) return res;
            object propVal = obj.GetPropertyValue<object>((string)parameters[0]);
            if ((propVal == null || propVal.ToString().Trim ()  == "") & obj.IsActive == true )
            {
                res.HasErrors = true;
                res.Messages.Add(new Message(MessageSeverity.Error, Err.ValueRequired));
            }
            return res;
        }

        public static Result CheckConditionalRequired(IBusinessObjectBase obj, params object[] parameters)
        {
            Result res = new Result();
            bool condVal = obj.GetPropertyValue<bool>((string)parameters[0]);
            if (condVal)
            {
                object propVal = obj.GetPropertyValue<object>((string)parameters[1]);
                if (propVal == null || propVal.ToString() == "")
                {
                    res.HasErrors = true;
                    res.Messages.Add(new Message(MessageSeverity.Error, Err.ValueRequired));
                }
            }
            return res;
        }

        public static Result CheckConditionalRequiredFromNot(IBusinessObjectBase obj, params object[] parameters)
        {
            Result res = new Result();
            bool condVal = obj.GetPropertyValue<bool>((string)parameters[0]);
            if (!condVal)
            {
                object propVal = obj.GetPropertyValue<object>((string)parameters[1]);
                if (propVal == null || propVal.ToString() == "")
                {
                    res.HasErrors = true;
                    res.Messages.Add(new Message(MessageSeverity.Error, Err.ValueRequired));
                }
            }
            return res;
        }

        /// <summary>
        /// return eror if one of to is not filled
        /// </summary>
        public static Result CheckOneOfTwoRequired(IBusinessObjectBase obj, params object[] parameters)
        //JB: returns error if of 3 properties none is true
        {
            Result res = new Result();
            object condVal1 = obj.GetPropertyValue<object>((string)parameters[0]);
            object condVal2 = obj.GetPropertyValue<object>((string)parameters[1]);
            if (condVal1 == null && condVal2 == null)
            {
                res.HasErrors = true;
                res.Messages.Add(new Message(MessageSeverity.Error, Err.ValueRequired));
            }
            return res;
        }

        /// <summary>
        /// Atgriež erroru, ja neviens no 3 parametriem nav 'True'
        /// </summary>
        public static Result CheckOneOfThreeRequired(IBusinessObjectBase obj, params object[] parameters)
        //JB: returns error if of 3 properties none is true
        {
            Result res = new Result();
            bool condVal1 = obj.GetPropertyValue<bool>((string)parameters[0]);
            bool condVal2 = obj.GetPropertyValue<bool>((string)parameters[1]);
            bool propVal = obj.GetPropertyValue<bool>((string)parameters[2]);
            if (!condVal1 && !condVal2 && !propVal)
            {
                res.HasErrors = true;
                res.Messages.Add(new Message(MessageSeverity.Error, Err.ValueRequired));
            }
            return res;
        }

        public static Result CheckNonNegativeDigit(IBusinessObjectBase obj, params object[] parameters)
        {
            Result res = new Result();
            Nullable<double> s = obj.GetPropertyValue<Nullable<double>>((string)parameters[0]);
            if (s != null && s < 0)
            {
                res.HasErrors = true;
                res.Messages.Add(new Message(MessageSeverity.Error, Err.Negative ));
            }

            return res;
        }

        public static Result CheckNonNegativeDigitDecimal(IBusinessObjectBase obj, params object[] parameters)
        {
            Result res = new Result();
            Nullable<decimal> s = obj.GetPropertyValue<Nullable<decimal>>((string)parameters[0]);
            if (s != null && s < 0)
            {
                res.HasErrors = true;
                res.Messages.Add(new Message(MessageSeverity.Error, Err.Negative));
            }

            return res;
        }

        public static Result CheckNonNegativeDigitInt(IBusinessObjectBase obj, params object[] parameters)
        {
            Result res = new Result();
            Nullable<int> s = obj.GetPropertyValue<Nullable<int>>((string)parameters[0]);
            if (s != null && s < 0)
            {
                res.HasErrors = true;
                res.Messages.Add(new Message(MessageSeverity.Error, Err.Negative));
            }

            return res;
        }
        public static Result CheckMaxLength(IBusinessObjectBase obj, params object[] parameters)
        {
            Result res = new Result();
            string s = obj.GetPropertyValue<string>((string)parameters[0]);
            int maxLen = (int)parameters[1];

            if (s == null || s.Length <= maxLen || obj.IsActive == false) return res;
            res.HasErrors = true;
            res.Messages.Add(new Message(MessageSeverity.Error, Err.TooLong, maxLen));
            return res;
        }

        public static Result CheckMaxDoubleValue(IBusinessObjectBase obj, params object[] parameters)
        {
            Result res = new Result();
            object temp = obj.GetPropertyValue<object>((string)parameters[0]);
            Nullable<double> s = obj.GetPropertyValue<Nullable<double>>((string)parameters[0]);
            double max = Convert.ToDouble(parameters[1]);

            if (s != null && s > max)
            {
                res.HasErrors = true;
                res.Messages.Add(new Message(MessageSeverity.Error, Err.TooBig, max));
            }
            return res;
        }

        public static Result CheckMinLength(IBusinessObjectBase obj, params object[] parameters)
        {
            Result res = new Result();
            if (obj.IsActive==false) return res;
            string s = obj.GetPropertyValue<string>((string)parameters[0]);
            int minLen = (int)parameters[1];

            if (s == null || s.ToString() == "" || s.Length >= minLen || obj.IsActive == false) return res;
            res.HasErrors = true;
            res.Messages.Add(new Message(MessageSeverity.Error, Err.TooShort, minLen ));
            return res;
        }

        public static Result CheckNotFutureDate(IBusinessObjectBase obj, params object[] parameters)
        {
            Result res = new Result();
            Nullable<DateTime> theDate = obj.GetPropertyValue<Nullable<DateTime>>((string)parameters[0]);
            if (theDate != null && theDate > DateTime.Today)
            {
                res.HasErrors = true;
                res.Messages.Add(new Message(MessageSeverity.Error, Err.FutureDate));
            }
            return res;
        }

        public static Result CheckConditionalNotPastDate(IBusinessObjectBase obj, params object[] parameters)
        {
            Result res = new Result();
      
            bool condVal = obj.GetPropertyValue<bool>((string)parameters[0]);
            if (condVal)
            {
                Nullable<DateTime> theDate = obj.GetPropertyValue<Nullable<DateTime>>((string)parameters[1]);
                if (theDate != null && theDate < DateTime.Today)
                {
                    res.HasErrors = true;
                    res.Messages.Add(new Message(MessageSeverity.Error, Err.PastDate));
                }
            }
            return res;
        }

        public static Result CheckDateInterval(IBusinessObjectBase obj, params object[] parameters)
        {
            Result res = new Result();
            Nullable<DateTime> dateFrom = obj.GetPropertyValue<Nullable<DateTime>>((string)parameters[0]);
            Nullable<DateTime> dateUntil = obj.GetPropertyValue<Nullable<DateTime>>((string)parameters[1]);
            if (dateFrom != null && dateUntil != null && dateFrom > dateUntil)
            {
                res.HasErrors = true;
                res.Messages.Add(new Message(MessageSeverity.Error, Err.InvalidDateInterval));
            }
            return res;
        }

        public static Result CheckTimeInterval(IBusinessObjectBase obj, params object[] parameters)
        {
            Result res = new Result();
            Nullable<DateTime> dateFrom = obj.GetPropertyValue<Nullable<DateTime>>((string)parameters[0]);
            Nullable<DateTime> dateUntil = obj.GetPropertyValue<Nullable<DateTime>>((string)parameters[1]);
            if (dateFrom != null && dateUntil != null && dateFrom.Value.TimeOfDay > dateUntil.Value.TimeOfDay)
            {
                res.HasErrors = true;
                res.Messages.Add(new Message(MessageSeverity.Error, Err.InvalidDateInterval));
            }
            return res;
        }

        public static Result CheckTimeIntervalOverlap(IBusinessObjectBase obj, params object[] parameters)
        {
            Result res = new Result();
            string _value = obj.GetPropertyValue<string>((string)parameters[0]);
            if (!string.IsNullOrEmpty(_value))
            {

                res.HasErrors = true;
                res.Messages.Add(new Message(MessageSeverity.Error, Err.TimeIntervalOverlap, _value));
            }
            return res;
        }

        public static Result CheckDateIntervalDateOnly(IBusinessObjectBase obj, params object[] parameters)
        {
            Result res = new Result();
            Nullable<DateTime> dateFrom = obj.GetPropertyValue<Nullable<DateTime>>((string)parameters[0]);
            Nullable<DateTime> dateUntil = obj.GetPropertyValue<Nullable<DateTime>>((string)parameters[1]);
            if (dateFrom != null && dateUntil != null && dateFrom.Value.Date  > dateUntil.Value.Date )
            {
                res.HasErrors = true;
                res.Messages.Add(new Message(MessageSeverity.Error, Err.InvalidDateInterval));
            }
            return res;
        }

        public static Result CheckConditionalDateInterval(IBusinessObjectBase obj, params object[] parameters)
        {
            Result res = new Result();
            bool condVal = obj.GetPropertyValue<bool>((string)parameters[0]);
            if (condVal)
            {
                Nullable<DateTime> dateFrom = obj.GetPropertyValue<Nullable<DateTime>>((string)parameters[1]);
                Nullable<DateTime> dateUntil = obj.GetPropertyValue<Nullable<DateTime>>((string)parameters[2]);
                if (dateFrom != null && dateUntil != null && dateFrom > dateUntil)
                {
                    res.HasErrors = true;
                    res.Messages.Add(new Message(MessageSeverity.Error, Err.InvalidDateInterval));
                }
            }
            return res;
        }

        public static Result CheckConditionalDateIntervalDateOnly (IBusinessObjectBase obj, params object[] parameters)
        {
            Result res = new Result();
            bool condVal = obj.GetPropertyValue<bool>((string)parameters[0]);
            if (condVal)
            {
                Nullable<DateTime> dateFrom = obj.GetPropertyValue<Nullable<DateTime>>((string)parameters[1]);
                Nullable<DateTime> dateUntil = obj.GetPropertyValue<Nullable<DateTime>>((string)parameters[2]);
                if (dateFrom != null && dateUntil != null && dateFrom.Value.Date  > dateUntil.Value.Date )
                {
                    res.HasErrors = true;
                    res.Messages.Add(new Message(MessageSeverity.Error, Err.InvalidDateInterval));
                }
            }
            return res;
        }

        public static Result CheckDateBetween(IBusinessObjectBase obj, params object[] parameters)
        {
            Result res = new Result();
            Nullable<DateTime> start = obj.GetPropertyValue<Nullable<DateTime>>((string)parameters[0]);
            Nullable<DateTime> end = obj.GetPropertyValue<Nullable<DateTime>>((string)parameters[1]);
            Nullable<DateTime> startTime = obj.GetPropertyValue<Nullable<DateTime>>((string)parameters[2]);
            Nullable<DateTime> endTime = obj.GetPropertyValue<Nullable<DateTime>>((string)parameters[3]);
            if (start != null && end != null && startTime != null && endTime != null && (startTime<start || endTime>end))
            {
                res.HasErrors = true;
                res.Messages.Add(new Message(MessageSeverity.Error, Err.InvalidVisitTime, start, end));
                }
            return res;
        }

        public static Result CheckDependenceFromStatus(IBusinessObjectBase obj, params object[] parameters)
        {
            //LP - vērtība, statuss, statusi-pie kuriem attiecīgais lauks nevar bût null []
            Result res = new Result();
            object propVal = obj.GetPropertyValue<object>((string)parameters[0]);
            object propStatus = obj.GetPropertyValue<object>((string)parameters[1]);
            int i = 0;

            if (propVal == null || propVal.ToString() == "")
            {
                foreach (object e in parameters)
                {
                    if (i > 1 & System.Convert.ToString(propStatus) == System.Convert.ToString(e))
                    {
                        res.HasErrors = true;
                        res.Messages.Add(new Message(MessageSeverity.Error, Err.ValueRequired));
                    }
                    i += 1;
                }
            }
            return res;
        }

        public static Result CheckConditionalRequiredObj(IBusinessObjectBase obj, params object[] parameters)
        {
            //LP 
            Result res = new Result();
            object condVal = obj.GetPropertyValue<object>((string)parameters[0]);

            if (condVal != null)
            {
                object propVal = obj.GetPropertyValue<object>((string)parameters[1]);
                if (propVal == null || propVal.ToString() == "")
                {
                    res.HasErrors = true;
                    res.Messages.Add(new Message(MessageSeverity.Error, Err.ValueRequired));
                }
            }
            return res;
        }

        public static Result CheckConditionalRequiredFromBooleanObj(IBusinessObjectBase obj, params object[] parameters)
        { 
            Result res = new Result();
            object condVal = obj.GetPropertyValue<object>((string)parameters[0]);
            if (condVal != null)
            {
            Type type = condVal.GetType();
                if (type.Name=="Boolean")
                {                
                    if ((bool)condVal)
                    {
                        object propVal = obj.GetPropertyValue<object>((string)parameters[1]);
                        if (propVal == null || propVal.ToString() == "")
                        {
                            res.HasErrors = true;
                            res.Messages.Add(new Message(MessageSeverity.Error, Err.ValueRequired));
                        }
                    }
                }
            }
            return res;
        }

        public static Result CheckConditionalRequiredFromEnumValue(IBusinessObjectBase obj, params object[] parameters)
        {
            Result res = new Result();
            object condVal = obj.GetPropertyValue<object>((string)parameters[0]);
            if (condVal != null)
            {
                Type type = condVal.GetType();
                if (type.Name == "Boolean")
                {
                    if ((bool)condVal)
                    {
                        object propVal = obj.GetPropertyValue<object>((string)parameters[1]);
                        if (propVal == null || propVal.ToString() == "")
                        {
                            res.HasErrors = true;
                            res.Messages.Add(new Message(MessageSeverity.Error, Err.ValueRequired));
                        }
                    }
                }
            }
            return res;
        }

        public static Result CheckDateValue(IBusinessObjectBase obj, params object[] parameters)
        {
            //LP - ievadītais datums; datums, par kuru nevar bût mazāks ievadītais datums, nevar bût lielāks "Grt"/nevar bût mazāks "Les", salīzdināt/nesalīdzināt arī laiku True/False 
            Result res = new Result();
            Nullable<DateTime> editDate = obj.GetPropertyValue<Nullable<DateTime>>((string)parameters[0]);
            Nullable<DateTime> checkDate;
            if (parameters[1] == null) return res;
            Type type = parameters[1].GetType ();
            if (type == typeof(System.DateTime))
                { checkDate = (DateTime)parameters[1]; }
            else
                { checkDate = obj.GetPropertyValue<Nullable<DateTime>>((string)parameters[1]); }
            String check = (string)parameters[2];
            bool chechTime = false;
            if (parameters.Length ==4)
                { chechTime = (bool)parameters[3]; }
            
            if (check == "Les")
            {
                if (editDate != null && checkDate != null )
                {
                    if (chechTime == true && Convert.ToDateTime(editDate.Value.ToString("dd.MM.yyyy HH:mm")) < Convert.ToDateTime(checkDate.Value.ToString("dd.MM.yyyy HH:mm")))
                    {
                        res.HasErrors = true;
                        res.Messages.Add(new Message(MessageSeverity.Error, Err.InvalidDateValueLes, checkDate.Value.ToString("dd.MM.yyyy HH:mm")));
                    }
                    else if (chechTime == false && Convert.ToDateTime(editDate.Value.ToString("d")) < Convert.ToDateTime(checkDate.Value.ToString("d")))
                    {
                        res.HasErrors = true;
                        res.Messages.Add(new Message(MessageSeverity.Error, Err.InvalidDateValueLes, checkDate.Value.ToString("d")));
                    }                    
                }
            }
            else if (check == "Grt")
            {
                if (editDate != null && checkDate != null)
                {
                    if (chechTime == true && Convert.ToDateTime(editDate.Value.ToString("dd.MM.yyyy HH:mm")) > Convert.ToDateTime(checkDate.Value.ToString("dd.MM.yyyy HH:mm")))
                    {
                        res.HasErrors = true;
                        res.Messages.Add(new Message(MessageSeverity.Error, Err.InvalidDateValueGrt, checkDate.Value.ToString("dd.MM.yyyy HH:mm")));
                    }
                    else if (chechTime == false && Convert.ToDateTime(editDate.Value.ToString("d")) > Convert.ToDateTime(checkDate.Value.ToString("d")))
                    {
                        res.HasErrors = true;
                        res.Messages.Add(new Message(MessageSeverity.Error, Err.InvalidDateValueGrt, checkDate.Value.ToString("d")));
                    }   
                }
            }

            return res;
        }

        public static Result CheckParentChildDate(IBusinessObjectBase obj, params object[] parameters)
        //dateFrom < date < dateUntil 
        {
            Result res = new Result();
            IBusinessObjectBase parent = obj.GetPropertyValue<IBusinessObjectBase>((string)parameters[3]);
            if (parent == null) { return res;}
            Nullable<DateTime> dateFrom = parent.GetPropertyValue<Nullable<DateTime>>((string)parameters[0]);
            Nullable<DateTime> dateUntil = parent.GetPropertyValue<Nullable<DateTime>>((string)parameters[1]);
            Nullable<DateTime> date = obj.GetPropertyValue<Nullable<DateTime>>((string)parameters[2]);
            bool IsActiveParent = parent.GetPropertyValue<bool>((string)parameters[4]);
            bool IsActive = obj.GetPropertyValue<bool>((string)parameters[4]);


            if (IsActiveParent && IsActive && dateFrom.HasValue && dateUntil.HasValue && date.HasValue )
            {
                if (Convert.ToDateTime(date.Value.ToString("d")) < Convert.ToDateTime(dateFrom.Value.ToString("d")) || Convert.ToDateTime(date.Value.ToString("d")) > Convert.ToDateTime(dateUntil.Value.ToString("d")))
                {
                    res.HasErrors = true;
                    res.Messages.Add(new Message(MessageSeverity.Error, Err.InvalidDateInclusion));
                }
            }
            return res;
        }

        public static Result CheckDecimalValue(IBusinessObjectBase obj, params object[] parameters)
        {
            //LP - ievadītais skaitlis; skaitlis, par kuru nevar bût mazāks ievadītais skaitlis, nevar bût lielāks "Grt"/nevar bût mazāks "Les"
            Result res = new Result();
            Nullable<Decimal> editDec = obj.GetPropertyValue<Nullable<Decimal>>((string)parameters[0]);
            Nullable<Decimal> checkDec;
            Type type = parameters[1].GetType();
            if (type == typeof(System.Decimal))
            { checkDec = (Decimal)parameters[1]; }
            else
            { checkDec = obj.GetPropertyValue<Nullable<Decimal>>((string)parameters[1]); }
            String check = (string)parameters[2];

            if (check == "Les")
            {
                if (editDec != null && checkDec != null)
                {
                    if (editDec.Value < checkDec.Value)
                    {
                        res.HasErrors = true;
                        res.Messages.Add(new Message(MessageSeverity.Error, Err.InvalidDecimalValueLes, checkDec.Value.ToString("f")));
                    }
                }
            }
            else if (check == "Grt")
            {
                if (editDec != null && checkDec != null)
                {
                    if (editDec.Value > checkDec.Value)
                    {
                        res.HasErrors = true;
                        res.Messages.Add(new Message(MessageSeverity.Error, Err.InvalidDecimalValueGrt, checkDec.Value.ToString("f")));
                    }
                }
            }

            return res;
        }

        /// <summary>
        /// return error if both are true
        /// </summary>
        public static Result CheckBothBooleanTrue(IBusinessObjectBase obj, params object[] parameters)
        {
            Result res = new Result();
            bool condVal1 = obj.GetPropertyValue<bool>((string)parameters[0]);
            bool condVal2 = obj.GetPropertyValue<bool>((string)parameters[1]);
            if (condVal1 && condVal2)
            {
                res.HasErrors = true;
                res.Messages.Add(new Message(MessageSeverity.Error, Err.HasFieldErrors));
            }
            return res;
        }
        
    }
}
