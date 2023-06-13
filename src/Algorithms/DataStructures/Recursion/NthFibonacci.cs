using Algorithms.DataStructures.LinkedLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DataStructures.LinkedLists
{
    internal class NthFibonacci
    {

        public static int Problem(int n)
        {
            var current = 1;
            var arr = new int[] { 0, 1 };

            return Recursion(n, current, arr);
        }

        public static int Recursion(int n, int current, int[] arr)
        {
            if (n == 0)
            {
                return 0;
            }

            if (n == 1)
            {
                return 0;
            }

            if (current == n)
            {
                return arr[0];
            }

            var sum = arr[0] + arr[1];

            arr[0] = arr[1];
            arr[1] = sum;
            
            return Recursion(n, current + 1, arr);
        }
    }
}
