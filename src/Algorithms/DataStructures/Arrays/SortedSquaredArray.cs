using System.Collections;

namespace Algorithms.DataStructures.Arrays
{
    internal class SortedSquaredArray
    {

        // IF ARRAY SORTED OR IN SPECIFIC ORDER, It should have a linear time alg= O(n)

        // This solution only works because the array is in ascending order

        // Write a function that takes in a non-empty array of integers that are sorted in ascending order
        // and returns a new array of the same length with the squares of the original integers also sorted in ascending order.
        //
        // Sample Input
        // array = [1, 2, 3, 5, 6, 8, 9]
        // Sample Output
        // [1, 4, 9, 25, 36, 64, 81]
        public static int[] Problem(int[] array)
        {
            var result = new int[array.Length];

            var firstIndex = 0;
            var lastIndex = array.Length - 1;

            var insertIndex = array.Length - 1;

            while (insertIndex > -1)
            {
                var left = array[firstIndex] * array[firstIndex];
                var right = array[lastIndex] * array[lastIndex];

                if (left > right)
                {
                    result[insertIndex] = left;
                    firstIndex++;
                }
                else
                {
                    result[insertIndex] = right;
                    lastIndex--;
                }

                insertIndex--;
            }

            return result;
        }
    }
}
