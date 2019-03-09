using Algorithms.Searching;
using NUnit.Framework;

namespace Algorithms.Tests
{
    public class SearchingTest
    {
        private class Item : ISearchable<int>
        {
            public Item(int key)
            {
                Key = key;
            }

            public int Key { get; }
        }

        [Test]
        public void BinarySearcherShouldFindItemInSortedItems()
        {
            Item[] items = new Item[] { new Item(1), new Item(13), new Item(45), new Item(89), new Item(156), new Item(3455), new Item(99456), new Item(4333453) };

            var binarySearcher = new BinarySearcher<Item, int>();
            var item = binarySearcher.Search(items, 99456);

            Assert.AreEqual(99456, item.Key);
        }
    }
}
