using System;

namespace sorting_algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demonstration of sorting algorithms.");

            var randomGenerator = new System.Random();

            var testArray = ArrayFactory.GetRandomArray(randomGenerator.Next());

            BubbleSort.Sort(testArray);

            Console.WriteLine($"Is {nameof(testArray)} sorted by {nameof(BubbleSort)}?");
            Console.WriteLine(SortingAssessment.IsSorted(testArray));
        }
    }
}