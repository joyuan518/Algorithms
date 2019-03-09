using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Searching
{
    public abstract class BaseSearcher<TItem, TKey> where TItem: ISearchable<TKey> where TKey : IComparable
    {
        public abstract TItem Search(TItem[] items, TKey keyValue);
    }
}
