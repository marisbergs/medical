using System;
using System.Collections.Generic;
using System.Text;
using Core.Dal.Expressions;

namespace Core.Dal
{
    /// <summary>
    /// Contains helper methods for building various non-trivial Criteria expressions
    /// </summary>
    public static class CriteriaBuilder
    {
        /// <summary>
        /// Do intervals overlap?
        /// </summary>
        /// <param name="propertyFrom">Startpoint property of interval to be checked</param>
        /// <param name="propertyUntil">Endpoint property of interval to be checked</param>
        /// <param name="valueFrom">Startpoint value of interval to be compared with</param>
        /// <param name="valueUntil">Endpoint value of interval to be compared with</param>
        /// <returns>Criterion expression</returns>
        public static CriterionBase IntervalsOverlap(string propertyFrom, string propertyUntil, object valueFrom, object valueUntil)
        {
            //return new Not(new Or(new Gt(propertyFrom, valueUntil), new Lt(propertyUntil, valueFrom)));
            if (valueUntil == null )
               return new Gt(propertyUntil, valueFrom);
           else if (valueFrom == null)
               return new Lt(propertyUntil, valueUntil);
            else
                return new Not(new Or(new Gt(propertyFrom, valueUntil), new Lt(propertyUntil, valueFrom)));
                }
        
        public static CriterionBase IntervalCoversValue ( string propertyFrom, string propertyUntil, object value )
        {
            return new Or(
                new And(new IsNull(propertyUntil), new Le(propertyFrom, value)),
                new And(new Le(propertyFrom, value), new Ge(propertyUntil, value)));
        }

        public static CriterionBase FullIntervalCoversValue(string propertyFrom, string propertyUntil, object value)
        {
            return new Or(new Or(new Or(
                new And(new IsNull(propertyUntil), new Le(propertyFrom, value)),
                new And(new Le(propertyFrom, value), new Ge(propertyUntil, value))),
                new And(new IsNull(propertyFrom), new Ge(propertyUntil, value))),
                new And(new IsNull(propertyFrom), new IsNull(propertyUntil)));
        }


        /// <summary>
        /// Builds "In" expression, converting passed ICollection{T} to an array
        /// </summary>
        /// <typeparam name="T">Type of items in the collection</typeparam>
        /// <param name="propertyName">Property to be checked</param>
        /// <param name="collection">Collection</param>
        /// <returns>Criterion expression</returns>
        public static CriterionBase IsInCollection<T>(string propertyName, ICollection<T> collection)
        {
            if (collection == null)
                return new In(propertyName);

            object[] paramArray = new object[collection.Count];
            int i = 0;
            foreach (T c in collection)
                paramArray[i++] = c;
            return new In(propertyName, paramArray);
        }/// <summary>
        /// Builds "Not In" expression, converting passed ICollection{T} to an array
        /// </summary>
        /// <typeparam name="T">Type of items in the collection</typeparam>
        /// <param name="propertyName">Property to be checked</param>
        /// <param name="collection">Collection</param>
        /// <returns>Criterion expression</returns>
        public static CriterionBase IsNotInCollection<T>(string propertyName, ICollection<T> collection)
        {
            if (collection == null)
                return new In(propertyName);

            object[] paramArray = new object[collection.Count];
            int i = 0;
            foreach (T c in collection)
                paramArray[i++] = c;
            return new NotIn(propertyName, paramArray);
        }
        /// <summary>
        /// Generates Or'ed Like expressions, splitting the parameter string according to the separator character
        /// </summary>
        /// <param name="propertyName">Property to be checked</param>
        /// <param name="value">Single or multiple values</param>
        /// <param name="separator">Separator used</param>
        /// <returns></returns>
        public static CriterionBase MultiValueLike(string propertyName, string value, char separator)
        {
            string[] likes = value.Split(separator);
            CriterionBase result = null;
            foreach (string v in likes)
            {
                string param = v.Trim();
                if (!param.EndsWith("%"))
                    param = param + "%";
                result |= new Like(propertyName, param);
            }
            return result;
        }

        /// <summary>
        /// Generates Or'ed Like expressions, splitting the parameter string according to the separator character
        /// </summary>
        /// <param name="propertyName">Property to be checked</param>
        /// <param name="value">Single or multiple values</param>
        /// <param name="separator">Separator used</param>
        /// <returns></returns>
        public static CriterionBase IntMultiValueLike(string propertyName, string value, char separator)
        {
            string[] likes = value.Split(separator);
            CriterionBase result = null;
            //foreach (string v in likes)
            //{
            //    string param = v.Trim();
                result = new In(propertyName, likes);
            //}
            return result;
        }
        /// <summary>
        /// Overloaded version of <seealso cref="MultiValueLike(string,string,char)"/>
        /// </summary>
        /// <param name="propertyName"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CriterionBase MultiValueLike(string propertyName, string value)
        {
            return MultiValueLike(propertyName, value, '|');
        }

        /// <summary>
        /// Generates expression (DeleteTime IS NULL) OR (Id == @existingId) for usage in drop-downs
        /// </summary>
        /// <param name="existingId"></param>
        /// <returns></returns>
        public static IList<CriterionBase> CreatePickerSource(object existingId)
        {
            IList<CriterionBase> result = new List<CriterionBase>();
            result.Add(new Dal.Expressions.Or(new Dal.Expressions.IsNull("DeleteTime"), new Dal.Expressions.Eq("Id", existingId)));
            return result;
        }

    }
}
