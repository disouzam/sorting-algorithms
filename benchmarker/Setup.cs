using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;

using sorting_algorithms;

namespace benchmarker
{
    [MemoryDiagnoser]
    [SimpleJob(runStrategy: RunStrategy.Throughput, invocationCount: 512)]
    [CsvExporter, RPlotExporter]
    public class Setup
    {
        private int[] localTestArray;

        protected Setup()
        {
            //localTestArray = ArrayFactory.GetRandomArray(1000, 10);
            //localTestArray = ArraySamples.GetSample1();
        }

        [Params(1, 10, 100, 1000, 10000, 100000, 1000000)]
        //[Params(1,10,100)]
        public int ArraySize { get; set; }

        [IterationSetup]
        public void IterationSetup()
        {
            localTestArray = ArrayFactory.GetRandomArray(ArraySize, 10);
        }

        public static int[] GetSampleArray()
        {
            return ArraySamples.GetSample1();
        }

        [Benchmark(Baseline = true)]
        public void RunBubbleSort1()
        {
            //var testArray = GetSampleArray();

            //var testArray = localTestArray;
            BubbleSort.Sort1(localTestArray);
        }

        [Benchmark]
        public void RunBubbleSort2()
        {
            //var testArray = GetSampleArray();

            //var testArray = localTestArray;
            BubbleSort.Sort2(localTestArray);
        }

        [Benchmark]
        public void RunBubbleSort3()
        {
            //var testArray = GetSampleArray();

            //var testArray = localTestArray;
            BubbleSort.Sort3(localTestArray);
        }

        [Benchmark]
        public void RunQuickSort1()
        {
            //var testArray = GetSampleArray();

            //var testArray = localTestArray;
            QuickSort.Sort1(localTestArray);
        }

    }
}
