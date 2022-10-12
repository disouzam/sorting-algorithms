using BenchmarkDotNet.Attributes;

using sorting_algorithms;

namespace benchmarker
{
    [MemoryDiagnoser]
    public class Setup
    {
        public int[] GetSampleArray()
        {
            var seed = 10;
            var size = 1000;
            var testArray = ArrayFactory.GetRandomArray(size, seed);

            return testArray;
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
