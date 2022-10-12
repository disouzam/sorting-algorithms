namespace sorting_algorithms
{
    internal class BubbleSort
    {
        public static void Sort1(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = 0; j < array.Length; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        (array[j], array[j+1]) = (array[j+1], array[j]);
                    }
                }
            }
        }
    }
}
