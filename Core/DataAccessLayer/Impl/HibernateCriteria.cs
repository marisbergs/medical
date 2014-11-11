using NHibernate.Expression;
using Core.Dal.Expressions;
using System;
using System.Text;
using System.Collections.Generic;

namespace Core.Dal
{
    internal class NHibernateTranslator
    {
        public static NHibernate.Expression.AbstractCriterion Translate(Core.Dal.Expressions.CriterionBase criterion, IDictionary<string,string> names)
        {
            switch (criterion.GetType().Name)
            {
                case "Not":
                    {
                        Not expr = criterion as Not;
                        return new NHibernate.Expression.NotExpression(Translate(expr.Op, names));
                    }
                case "And":
                    {
                        And expr = criterion as And;
                        return new NHibernate.Expression.AndExpression(Translate(expr.Lhs, names), Translate(expr.Rhs, names));
                    }
                case "Or":
                    {
                        Or expr = criterion as Or;
                        return new NHibernate.Expression.OrExpression(Translate(expr.Lhs, names), Translate(expr.Rhs, names));
                    }
                case "IsNull":
                    {
                        IsNull expr = criterion as IsNull;
                        return new NHibernate.Expression.NullExpression(names[expr.PropertyName]);
                    }
                case "IsNotNull":
                    {
                        IsNotNull expr = criterion as IsNotNull;
                        return new NHibernate.Expression.NotNullExpression(names[expr.PropertyName]);
                    }
                case "Eq":
                    {
                        Eq expr = criterion as Eq;
                        return new NHibernate.Expression.EqExpression(names[expr.PropertyName], expr.Value);
                    }
                case "Ge":
                    {
                        Ge expr = criterion as Ge;
                        return new NHibernate.Expression.GeExpression(names[expr.PropertyName], expr.Value);
                    }
                case "Le":
                    {
                        Le expr = criterion as Le;
                        return new NHibernate.Expression.LeExpression(names[expr.PropertyName], expr.Value);
                    }
                case "Gt":
                    {
                        Gt expr = criterion as Gt;
                        return new NHibernate.Expression.GtExpression(names[expr.PropertyName], expr.Value);
                    }
                case "Lt":
                    {
                        Lt expr = criterion as Lt;
                        return new NHibernate.Expression.LtExpression(names[expr.PropertyName], expr.Value);
                    }
                case "Between":
                    {
                        Between expr = criterion as Between;
                        return new NHibernate.Expression.BetweenExpression(names[expr.PropertyName], expr.Value1, expr.Value2);
                    }
                case "NotEq":
                    {
                        NotEq expr = criterion as NotEq;
                        return new NHibernate.Expression.NotExpression(new NHibernate.Expression.EqExpression(names[expr.PropertyName], expr.Value));
                    }
                case "Like":
                    {
                        Like expr = criterion as Like;
                        return new NHibernate.Expression.InsensitiveLikeExpression(names[expr.PropertyName], (string)expr.Value, MatchMode.Exact);
                    }
                case "In":
                    {
                        In expr = criterion as In;
                        return new NHibernate.Expression.InExpression(names[expr.PropertyName], expr.Values);
                    }
                case "NotIn":
                    {
                        NotIn expr = criterion as NotIn;
                        return new NHibernate.Expression.NotExpression(new NHibernate.Expression.InExpression(names[expr.PropertyName], expr.Values));
                    }
                case "Sql":
                    {
                        Sql expr = criterion as Sql;
                        return new NHibernate.Expression.SQLCriterion(expr.SqlString, expr.Values, expr.Types);
                    }
                default:
                    {
                        throw new NotImplementedException(criterion.GetType().Name);
                    }
            }
            return null;
        }

    }

}