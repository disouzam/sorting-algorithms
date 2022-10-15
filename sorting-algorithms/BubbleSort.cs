namespace sorting_algorithms
{
    public class BubbleSort
    {
        public static void Sort1(int[] array)
        {
            for (var outerLoop = 0; outerLoop < array.Length; outerLoop++)
            {
                for (var innerLoop = 0; innerLoop < array.Length - 1; innerLoop++)
                {
                    if (array[innerLoop] > array[innerLoop+1])
                    {
                        (array[innerLoop], array[innerLoop+1]) = (array[innerLoop+1], array[innerLoop]);
                    }
                }
            }
        }

        public static void Sort2(int[] array)
        {
            for (var outerLoop = array.Length -1; outerLoop >= 0; outerLoop--)
            {
                for (var innerLoop = 0; innerLoop < outerLoop; innerLoop++)
                {
                    if (array[innerLoop] > array[innerLoop+1])
                    {
                        (array[innerLoop], array[innerLoop+1]) = (array[innerLoop+1], array[innerLoop]);
                    }
                }
            }
        }

        public static void Sort3(int[] array)
        {
            for (var outerLoop = array.Length - 1; outerLoop >= 0; outerLoop--)
            {
                var changes = 0;

                for (var innerLoop = 0; innerLoop < outerLoop; innerLoop++)
                {
                    if (array[innerLoop] > array[innerLoop+1])
                    {
                        (array[innerLoop], array[innerLoop+1]) = (array[innerLoop+1], array[innerLoop]);
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
