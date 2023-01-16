namespace Algorithms.DataStructures.Arrays
{
    // Given an array of positive integers representing the values of coins in your possession,
    // write a function that returns the minimum amount of change(the minimum sum of money)
    // that you cannot create.The given coins can have any
    // positive integer value and aren't necessarily unique
    // (i.e., you can have multiple coins of the same value).

    // For example, if you're given coins = [1, 2, 5],
    // the minimum amount of change that you can't create is 4.
    // If you're given no coins, the minimum amount of change that you can't create is 1.

    // Sample Input
    // coins = [5, 7, 1, 1, 2, 3, 22]
    // Sample Output: 20
    internal class NonConstructibleChange
    {
        // + sort = 0 (n log n)
        // + 1 iteration with array = linear time ( O(n) )
        // 0 (n log n) = ( 0(nlogn) > O(n) )
        public static int Problem(int[] coins)
        {
            // sort
            // [1, 1, 2, 3, 5, 7, 22]
            // [ 1, 2, 3, 4, 5, 6, 7 ]
            var array = new List<int>(coins);
            array.Sort();

            // logic
            // if (V > S + 1) return S + 1
            var sum = 0;

            for (var i = 0; i < array.Count; i++)
            {
                var value = array[i];

                if (value > sum + 1)
                {
                    return sum + 1;
                }

                sum += value;
            }

            return sum + 1;
        }
    }
}
