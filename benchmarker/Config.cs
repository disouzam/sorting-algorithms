﻿using BenchmarkDotNet.Configs;
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
                    LaunchCount = 5,
                    UnrollFactor = 5
                },
                Accuracy =
                {
                    MaxRelativeError = 0.001,
                    MinIterationTime = TimeInterval.Millisecond * 500
                },
            }); ;
            AddDiagnoser(MemoryDiagnoser.Default);
            AddExporter(RPlotExporter.Default);
        }
    }
}
