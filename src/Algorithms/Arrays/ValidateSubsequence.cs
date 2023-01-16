using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Arrays
{
    internal class ValidateSubsequence
    {
        
        // Given two non-empty arrays of integers, write a function that determines whether the second array is a
        // subsequence of the first one.
           
        // A subsequence of an array is a set of numbers that aren't necessarily adjacent in the array
        // but that are in the same order as they appear in the array.
        // For instance, the numbers [1, 3, 4] form a subsequence of the array [1, 2, 3, 4],
        // and so do the numbers [2, 4].
        // Note that a single number in an array and the array itself are both valid subsequences of the array.
           
        // Sample Input
        // array = [5, 1, 22, 25, 6, -1, 8, 10]
        // sequence = [1, 6, -1, 10]
        // Sample Output: true
        public static bool Problem(List<int> array, List<int> sequence)
        {
            var finds = 0;
            var index = 0;

            for (var i = 0; i <= sequence.Count - 1; i++)
            {
                index = TraverseArray(index, sequence[i], array);

                if (index == -1)
                {
                    return false;
                }

                finds++;
                index++;

                if (finds == sequence.Count)
                {
                    return true;
                }
            }

            return false;
        }

        public static int TraverseArray(int startingPoint, int targetValue, List<int> array)
        {
            for (var i = startingPoint; i <= array.Count - 1; i++) 
            {
                if (array[i] == targetValue)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
