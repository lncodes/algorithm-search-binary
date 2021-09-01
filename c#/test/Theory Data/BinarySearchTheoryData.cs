using Xunit;
using System.Collections.Generic;

namespace Lncodes.Algorithm.Search.Binary.Test
{
    public sealed class BinarySearchTheoryData : TheoryData<IReadOnlyList<int>, int, int>
    {
        public BinarySearchTheoryData()
        {
            Add(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, 1, 0);
            Add(new int[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 }, 20, 9);
            Add(new List<int> { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 }, 15, 7);
        }
    }
}
