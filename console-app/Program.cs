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
            long startTime;
            long endTime;
            int arraySize = 1000000;
            var randomGenerator = new System.Random();
            var seed = randomGenerator.Next(arraySize);

            int[] testArray;

            // QuickSort > Sort 1
            testArray = ArrayFactory.GetRandomArray(arraySize, seed);
            startTime = DateTime.Now.Ticks;
            QuickSort.Sort1(testArray);
            endTime = DateTime.Now.Ticks;

            Console.WriteLine($"{nameof(QuickSort)}.{nameof(QuickSort.Sort1)} took {TimeSpan.FromTicks(endTime-startTime).TotalSeconds:F4} seconds to sort an array with {arraySize} elements.");
            PrintArray(testArray);

            Console.WriteLine($"Is {nameof(testArray)} sorted by {nameof(QuickSort)}.{nameof(QuickSort.Sort1)}?");
            Console.WriteLine(SortingAssessment.IsSorted(testArray));
            Console.WriteLine();

            // BubbleSort > Sort 3
            testArray = ArrayFactory.GetRandomArray(arraySize, seed);
            startTime = DateTime.Now.Ticks;
            BubbleSort.Sort3(testArray);
            endTime = DateTime.Now.Ticks;

            Console.WriteLine($"{nameof(BubbleSort)}.{nameof(BubbleSort.Sort3)} took {TimeSpan.FromTicks(endTime-startTime).TotalSeconds:F4} seconds to sort an array with {arraySize} elements.");
            PrintArray(testArray);

            Console.WriteLine($"Is {nameof(testArray)} sorted by {nameof(BubbleSort)}.{nameof(BubbleSort.Sort3)}?");
            Console.WriteLine(SortingAssessment.IsSorted(testArray));
            Console.WriteLine();

            // BubbleSort > Sort 2
            testArray = ArrayFactory.GetRandomArray(arraySize, seed);
            startTime = DateTime.Now.Ticks;
            BubbleSort.Sort2(testArray);
            endTime = DateTime.Now.Ticks;

            Console.WriteLine($"{nameof(BubbleSort)}.{nameof(BubbleSort.Sort2)} took {TimeSpan.FromTicks(endTime-startTime).TotalSeconds:F4} seconds to sort an array with {arraySize} elements.");
            PrintArray(testArray);

            Console.WriteLine($"Is {nameof(testArray)} sorted by {nameof(BubbleSort)}.{nameof(BubbleSort.Sort2)}?");
            Console.WriteLine(SortingAssessment.IsSorted(testArray));
            Console.WriteLine();

            // BubbleSort > Sort 1
            testArray = ArrayFactory.GetRandomArray(arraySize, seed);
            startTime = DateTime.Now.Ticks;
            BubbleSort.Sort1(testArray);
            endTime = DateTime.Now.Ticks;

            Console.WriteLine($"{nameof(BubbleSort)}.{nameof(BubbleSort.Sort1)} took {TimeSpan.FromTicks(endTime-startTime).TotalSeconds:F4} seconds to sort an array with {arraySize} elements.");
            PrintArray(testArray);

            Console.WriteLine($"Is {nameof(testArray)} sorted by {nameof(BubbleSort)}.{nameof(BubbleSort.Sort1)}?");
            Console.WriteLine(SortingAssessment.IsSorted(testArray));
            Console.WriteLine();
        }

        internal static void PrintArray(int[] array)
        {
            var year = DateTime.Now.Year;
            var month = DateTime.Now.Month;
            var day = DateTime.Now.Day;
            var hour = DateTime.Now.Hour;
            var minute = DateTime.Now.Minute;
            var second = DateTime.Now.Second;
            var filePath = $"{Directory.GetCurrentDirectory()}\\arrayValue-{year}-{month}-{day}-{hour}-{minute}-{second}.txt";

            var stringBuilder = new StringBuilder();

            stringBuilder.Append("{");

            for (var i = 0; i < array.Length; i++)
            {
                stringBuilder.Append($"{array[i]}");

                if (i < array.Length - 1)
                {
                    stringBuilder.Append(",");
                }
            }

            stringBuilder.Append("}");

            File.WriteAllText(filePath, stringBuilder.ToString());
        }
    }
}