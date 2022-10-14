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
                Run = { LaunchCount = 5, IterationTime = TimeInterval.Millisecond * 200 },
                Accuracy = { MaxRelativeError = 0.01 }
            });
            AddDiagnoser(MemoryDiagnoser.Default);
            AddExporter(RPlotExporter.Default);
        }
    }
}
