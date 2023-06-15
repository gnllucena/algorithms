using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DataStructures.Searching
{
    internal class Searching
    {
        public static void Green()
        {
            Console.WriteLine("BinarySearch");

            //var arr = new int[] { 0, 1, 21, 33, 45, 45, 61, 71, 72, 73 };
            //var target = 333;

            // var result = BinarySearch.Problem(arr, target);

            Console.WriteLine("ThreeLargestNumbers");

            var arr = new int[] { 141, 1, 17, -7, -17, -27, 18, 541, 8, 7, 7 };
            var result = PalindromeCheck.Problem(arr);
        }
    }
}
