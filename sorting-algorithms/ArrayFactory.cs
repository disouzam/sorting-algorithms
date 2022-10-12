namespace sorting_algorithms
{
    internal class ArrayFactory
    {
        public static int[] GetRandomArray(int size)
        {
            var array = new int[size];
            var randomGenerator = new System.Random();

            for (int i = 0; i < size; i++)
            {
               array[i] = randomGenerator.Next(int.MaxValue);
            }

            return array;
        }
    }
}
