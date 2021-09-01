using BenchmarkDotNet.Attributes;

namespace Lncodes.Algorithm.Search.Binary.Benchmark
{
    [MinColumn]
    [MaxColumn]
    [MemoryDiagnoser]
    public class RegulerBinarySearchBenchmark : BinarySearchBenchmark
    {
        private readonly BinarySearch _binarySearch = new BinarySearch();

        [Benchmark]
        public int Search() =>
            _binarySearch.Search(Data, Element);
    }
}
