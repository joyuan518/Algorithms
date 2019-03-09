using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Searching
{
    public interface ISearchable<TKey> where TKey : IComparable
    {
        TKey Key { get; }
    }
}
