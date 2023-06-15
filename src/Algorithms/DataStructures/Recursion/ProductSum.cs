using Algorithms.DataStructures.LinkedLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DataStructures.Recursion
{
    internal class ProductSum
    {
        public static int Problem(List<object> arr)
        {
            var sum = 0;
            var depth = 1;

            return Recursion(arr, depth, sum);
        }

        public static int Recursion(List<object> arr, int depth, int sum)
        {
            for (var i = 0; i < arr.Count; i++)
            {
                var current = arr[i];

                if (current is int)
                {
                    sum += Convert.ToInt32(current);
                }
                else
                {
                    var subarray = (depth + 1 ) * Recursion(current as List<object>, depth + 1, 0);

                    sum += subarray;
                }
            }
            
            return sum;
        }
    }
}
