using Xunit;
using System.Collections.Generic;

namespace Lncodes.Algorithm.Search.Binary.Test
{
    public sealed class RecursiveBinarySearchTest
    {
        [Theory]
        [ClassData(typeof(BinarySearchTheoryData))]
        public void Search_RecrusiveBinary_ShouldEqual(IReadOnlyList<int> data, int element, int expected)
        {
            var instance = new RecursiveBinarySearch();
            var actual = instance.Search(data, element, default, data.Count - 1);
            Assert.Equal(expected, actual);
        }
    }
}