using BenchmarkDotNet.Attributes;

using sorting_algorithms;

namespace benchmarker
{
    [Config(typeof(Config))]
    public class Setup
    {
        private int[] localTestArray;

        //[Params(1, 10, 100, 1000, 10000, 100000, 1000000)]
        //[Params(1, 10, 100)]
        [Params(1000)]
        public int ArraySize { get; set; }

        [IterationSetup]
        public void IterationSetup()
        {
            localTestArray = ArrayFactory.GetRandomArray(ArraySize, 10);
        }

        [Benchmark(Baseline = true)]
        public void RunBubbleSort1()
        {
            BubbleSort.Sort1(localTestArray);
        }

        [Benchmark]
        public void RunBubbleSort2()
        {
            BubbleSort.Sort2(localTestArray);
        }

        [Benchmark]
        public void RunBubbleSort3()
        {
            BubbleSort.Sort3(localTestArray);
        }

        [Benchmark]
        public void RunQuickSort1()
        {
            QuickSort.Sort1(localTestArray);
        }

    }
}
