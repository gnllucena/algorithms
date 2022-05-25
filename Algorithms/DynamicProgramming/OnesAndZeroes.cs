namespace Algorithms.DynamicProgramming
{
    // https://www.youtube.com/watch?v=xCbYmUPvc2Q (knapsack problem)
    // O(n.m) == O(n)
    internal class OnesAndZeroes
    {
        public static int Find(string[] strs, int m, int n)
        {
            int[,] matrix = new int[m + 1, n + 1];

            for (int i = 0; i < strs.Length; i++)
            {
                int one = 0;
                int zero = 0;


                for (int j = 0; j < strs[i].Length; j++)
                {
                    if (strs[i][j] == '0')
                    {
                        zero++;
                    }
                    else
                    {
                        one++;
                    }
                }

                for (int k = m; k >= zero; k--)
                {
                    for (int l = n; l >= one; l--)
                    {
                        matrix[k, l] = Math.Max(matrix[k, l], matrix[k - zero, l - one] + 1);
                    }
                }
            }

            return matrix[m, n];
        }
    }
}
