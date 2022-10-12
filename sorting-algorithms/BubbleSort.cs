namespace sorting_algorithms
{
    internal class BubbleSort
    {
        public static void Sort(int[] array)
        {
            for (var i = array.Length -1; i >= 0; i--)
            {
                for (var j = 0; j < i; j++)
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
