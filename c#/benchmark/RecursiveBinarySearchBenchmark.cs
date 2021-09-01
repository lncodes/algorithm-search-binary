using BenchmarkDotNet.Attributes;

namespace Lncodes.Algorithm.Search.Binary.Benchmark
{
    [MinColumn]
    [MaxColumn]
    [MemoryDiagnoser]
    public class RecursiveBinarySearchBenchmark : BinarySearchBenchmark
    {
        private readonly RecursiveBinarySearch _recursiveBinarySearch = new RecursiveBinarySearch();

        [Benchmark]
        public int Search() =>
            _recursiveBinarySearch.Search(Data, Element, default, Data.Count);
    }
}
