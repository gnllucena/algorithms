namespace Algorithms.DataStructures.Arrays
{
    // Write a function that takes in a non-empty array of distinct integers and an integer representing a target sum.
    // If any two numbers in the input array sum up to the target sum, the function should return them in an array, in any order.
    // If no two numbers sum up to the target sum, the function should return an empty array.

    // Note that the target sum has to be obtained by summingtwo different integers in the array;
    // you can't add a single integer to itself in order to obtain the target sum.

    // You can assume that there will be at most one pair of numbers summing up to the target sum.

    // Sample Input
    // array = [3, 5, -4, 8, 11, 1, -1, 6]
    // targetSum = 10
    // Sample Output
    // [-1, 11] 
    // the numbers could be in reverse order
    internal class TwoNumberSum
    {
        public static int[] Problem(int[] array, int targetSum)
        {
            var hashtable = new Dictionary<int, int>();

            for (var i = 0; i <= array.Length - 1; i++)
            {
                if (!hashtable.ContainsKey(array[i]))
                {
                    hashtable[array[i]] = i;
                }
            }

            for (var i = 0; i <= array.Length - 1; i++)
            {
                var x = array[i];

                var y = targetSum - x;

                if (y != x && hashtable.ContainsKey(y))
                {
                    return new int[] { x, array[hashtable[y]] };
                }
            }

            return new int[0];
        }
    }
}
