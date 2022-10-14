namespace sorting_algorithms
{
    public class BubbleSort
    {
        public static void Sort1(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        (array[j], array[j+1]) = (array[j+1], array[j]);
                    }
                }
            }
        }

        public static void Sort2(int[] array)
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

        public static void Sort3(int[] array)
        {
            for (var i = array.Length -1; i >= 0; i--)
            {
                var changes = 0;

                for (var j = 0; j < i; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        (array[j], array[j+1]) = (array[j+1], array[j]);
                        changes++;
                    }
                }

                if (changes == 0)
                {
                    break;
                }
            }
        }
    }
}
