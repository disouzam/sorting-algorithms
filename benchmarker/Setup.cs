using BenchmarkDotNet.Attributes;

using sorting_algorithms;

namespace benchmarker
{
    [MemoryDiagnoser]
    public class Setup
    {
        protected Setup()
        {

        }

        public static int[] GetSampleArray()
        {
            return ArraySamples.GetSample1();
        }

        [Benchmark(Baseline = true)]
        public void RunBubbleSort1()
        {
            var testArray = GetSampleArray();
            BubbleSort.Sort1(testArray);
        }

        [Benchmark]
        public void RunBubbleSort2()
        {
            var testArray = GetSampleArray();
            BubbleSort.Sort2(testArray);
        }

    }
}
