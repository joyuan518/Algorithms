using System;

namespace Algorithms.Searching
{
    public class BinarySearcher<TItem, TKey> : BaseSearcher<TItem, TKey> where TItem: ISearchable<TKey> where TKey: IComparable
    {
        public override TItem Search(TItem[] items, TKey keyValue)
        {
            if (items == null)
            {
                throw new ArgumentNullException(nameof(items));
            }

            int startIndex = 0, endIndex = items.Length - 1, scopeLength = items.Length;

            while (startIndex <= endIndex)
            {
                int middleIndex = startIndex + scopeLength / 2;
                var middleItem = items[middleIndex];

                if (middleItem == null)
                {
                    throw new NullReferenceException("Item can't be null!");
                }

                if (middleItem.Key.CompareTo(keyValue) == 0)
                {
                    return middleItem;
                }

                if (items[middleIndex].Key.CompareTo(keyValue) > 0)
                {
                    endIndex = middleIndex - 1;
                }
                else
                {
                    startIndex = middleIndex + 1;
                }

                scopeLength = endIndex - startIndex + 1; 
            }

            return default(TItem);
        }
    }
}
