namespace sorting_algorithms
{
    internal class SortingAssessment
    {
        public static bool IsSorted(int[] array)
        {
            for(var i = 0; i < array.Length; i++)
            {
                if (i > 0 && array[i] < array[i-1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
