using BenchmarkDotNet.Running;

namespace benchmarker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var results = BenchmarkRunner.Run<Setup>();
        }
    }
}