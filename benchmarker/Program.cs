using BenchmarkDotNet.Running;

namespace benchmarker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            _ = BenchmarkRunner.Run<Setup>();
        }
    }
}