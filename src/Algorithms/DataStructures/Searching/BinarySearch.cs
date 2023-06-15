using Algorithms.DataStructures.LinkedLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DataStructures.Searching
{
    internal class BinarySearch
    {
        public static int Problem(int[] arr, int target)
        {
            var left = 0;
            var right = arr.Length - 1;
            int middle = (left + right) / 2;

            return Recursion(arr, target, left, right, middle);
        }

        public static int Recursion(int[] arr, int target, int left, int right, int middle)
        {
            var middlePointer = arr[middle];

            if (left > right || right < left)
            {
                return -1;
            }
            else if (target > middlePointer)
            {
                var newLeft = middle + 1;

                return Recursion(arr, target, newLeft, right, (newLeft + right) / 2);
            }
            else if (target < middlePointer)
            {
                var newRight = middle - 1;

                return Recursion(arr, target, left, newRight, (left + newRight) / 2);
            }

            return middle;
        }
    }
}
