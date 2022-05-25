namespace Algorithms.Auxiliar.Sorting
{
    internal class Quicksort
    {
        public static void Sort(int[] array, int start, int end)
        {
            if (start < end)
            {
                var partition = Partition(array, start, end);

                Sort(array, start, partition - 1);
                Sort(array, partition + 1, end);
            }
        }

        private static int Partition(int[] array, int start, int end)
        {
            int temp;
            int p = array[end];
            int i = start - 1;

            for (int j = start; j <= end - 1; j++)
            {
                if (array[j] <= p)
                {
                    i++;
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }

            temp = array[i + 1];
            array[i + 1] = array[end];
            array[end] = temp;

            return i + 1;
        }
    }
}
