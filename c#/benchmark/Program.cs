using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;

namespace Lncodes.Algorithm.Search.Binary.Benchmark
{
    public sealed class Program
    {
        private static void Main(string[] args)
        {
            var config = ManualConfig.Create(DefaultConfig.Instance)
                .WithOptions(ConfigOptions.JoinSummary | ConfigOptions.DisableLogFile);
            _ = BenchmarkRunner.Run(typeof(Program).Assembly, config);
        }
    }
}