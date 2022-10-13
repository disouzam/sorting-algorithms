using System;
using System.IO;
using System.Text;

using sorting_algorithms;

namespace consoleapp
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demonstration of sorting algorithms.");

            var randomGenerator = new System.Random();

            //var testArray = ArrayFactory.GetRandomArray(randomGenerator.Next());
            var testArray = ArrayFactory.GetRandomArray(1000000, null);
            PrintArray(testArray);

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

        internal static void PrintArray(int[] array)
        {
            var filePath = $"{Directory.GetCurrentDirectory()}\\arrayValue.txt";

            var stringBuilder = new StringBuilder();

            stringBuilder.Append("[");


            for (var i = 0; i < array.Length; i++)
            {
                stringBuilder.Append($"{array[i]}");

                if (i < array.Length - 1)
                {
                    stringBuilder.Append(",");
                }
            }

            stringBuilder.Append("]");

            File.WriteAllText(filePath, stringBuilder.ToString());
        }
    }
}