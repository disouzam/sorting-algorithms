namespace sorting_algorithms
{
    public class ArrayFactory
    {
        public static int[] GetRandomArray(int size, int? seed)
        {
            var array = new int[size];
            System.Random randomGenerator;

            if (seed == null)
            {
                randomGenerator = new System.Random();
            }
            else
            {
                var convertedSeed = (int)seed;
                randomGenerator = new System.Random(convertedSeed);
            }

            for (int i = 0; i < size; i++)
            {
                array[i] = randomGenerator.Next(int.MaxValue);
            }

            return array;
        }
    }
}
