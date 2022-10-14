using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Jobs;

using Perfolizer.Horology;

namespace benchmarker
{
    internal class Config : ManualConfig
    {
        public Config()
        {
            AddJob(new Job("SortingBenchmarkJob", BenchmarkDotNet.Jobs.RunMode.Default)
            {
                Run =
                {
                    MinWarmupIterationCount = 10,
                    LaunchCount = 5, 
                    IterationTime = TimeInterval.Millisecond * 1000
                },
                Accuracy =
                {
                    MaxRelativeError = 0.001,
                    MinInvokeCount = 5
                },
            });
            AddDiagnoser(MemoryDiagnoser.Default);
            AddExporter(RPlotExporter.Default);
        }
    }
}
