namespace sorting_algorithms
{
    internal class QuickSort
    {
        public static void Sort1(int[] array)
        {
            RecursiveSort1(array, 0, array.Length - 1);
        }

        private static void RecursiveSort1(int[] array, int startIndex, int endIndex)
        {
            if (startIndex < endIndex)
            {
                var pi = Partition1(array, startIndex, endIndex);

                RecursiveSort1(array, startIndex, pi - 1);

                RecursiveSort1(array, pi + 1, endIndex);
            }
        }

        private static int Partition1(int[] array, int startIndex, int endIndex)
        {
            var pivotValue = array[endIndex];

            var i = startIndex - 1;

            for (var j = startIndex; j <= endIndex - 1; j++)
            {
                if (array[j] < pivotValue)
                {
                    i++;
                    (array[j], array[i]) = (array[i], array[j]);
                }
            }

            (array[i+1], array[endIndex]) = (array[endIndex], array[i+1]);
            var pivotIndex = i + 1;

            return pivotIndex;
        }
    }
}
