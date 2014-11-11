using System.Collections.Generic;
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;

namespace Core.Dal
{
    public interface IChildCollection<T> : IBindingList, IRaiseItemChangedEvents, IHasParent, Core.Bll.IValidatable
    {
        /// <summary>
        /// Filters existing collection according to supplied criteria
        /// </summary>
        /// <param name="criteria"></param>
        /// <returns></returns>
        IChildCollection<T> FilterItems(params Core.Dal.Expressions.CriterionBase[] criteria);
        IChildCollection<T> ActiveItemsWithoutEmpty{get;}
        IChildCollection<T> FilterItemsDistinct(params Core.Dal.Expressions.CriterionBase[] criteria);
        IChildCollection<T> ActiveItems { get; }
        string ToStringWithSeperator(string seperator);
        IList FilterItemsDistinctByProperty(string criteria);
        SortedDictionary<object, IList<object>> FilterItemsDistinctByPropertyWithValue(string criteria);
        SortedDictionary<object, IList<object>> FilterItemsDistinctByPropertyWithNothingReplaceValue(string criteria);
    }
}
