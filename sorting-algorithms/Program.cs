using System;

namespace sorting_algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demonstration of sorting algorithms.");

            var randomGenerator = new System.Random();

            BubbleSort.Sort1(testArray);

            Console.WriteLine($"Is {nameof(testArray)} sorted by {nameof(BubbleSort)}.{nameof(BubbleSort.Sort1)}?");
            Console.WriteLine(SortingAssessment.IsSorted(testArray));
            Console.WriteLine();

            BubbleSort.Sort2(testArray);

            Console.WriteLine($"Is {nameof(testArray)} sorted by {nameof(BubbleSort)}.{nameof(BubbleSort.Sort2)}?");
            Console.WriteLine(SortingAssessment.IsSorted(testArray));
            Console.WriteLine();

            BubbleSort.Sort3(testArray);

            Console.WriteLine($"Is {nameof(testArray)} sorted by {nameof(BubbleSort)}.{nameof(BubbleSort.Sort3)}?");
            Console.WriteLine(SortingAssessment.IsSorted(testArray));
            Console.WriteLine();

            QuickSort.Sort1(testArray);

            Console.WriteLine($"Is {nameof(testArray)} sorted by {nameof(QuickSort)}.{nameof(QuickSort.Sort1)}?");
            Console.WriteLine(SortingAssessment.IsSorted(testArray));
            Console.WriteLine();

        }
    }
}