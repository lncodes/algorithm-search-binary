using Xunit;
using System.Collections.Generic;

namespace Lncodes.Algorithm.Search.Binary.Test
{
    public sealed class BinarySearchTest
    {
        [Theory]
        [ClassData(typeof(BinarySearchTheoryData))]
        public void Search_Binary_ShouldEqual(IReadOnlyList<int> data, int element, int expected)
        {
            var instance = new BinarySearch();
            var actual = instance.Search(data, element);
            Assert.Equal(expected, actual);
        }
    }
}