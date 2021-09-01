using System.Collections.Generic;

namespace Lncodes.Algorithm.Search.Binary.Benchmark
{
    public abstract class BinarySearchBenchmark
    {
        protected readonly int Element = 10;
        protected IReadOnlyList<int> Data = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    }
}