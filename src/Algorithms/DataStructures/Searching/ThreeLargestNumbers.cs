using Algorithms.DataStructures.LinkedLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DataStructures.Searching
{
    internal class PalindromeCheck
    {
        public static int[] Problem(int[] arr)
        {
            var largest = new int[3] { int.MinValue, int.MinValue, int.MinValue };

            for (var i = 0; i < arr.Length; i++)
            {
                AddToLargestArray(largest, arr[i]);
            }

            return largest;
        }

        public static int FindIndexToInsert(int[] largest, int current)
        {
            for (var i = 0; i < largest.Length; i++)
            {
                if (current > largest[i])
                {
                    if (i == largest.Length - 1)
                    {
                        return i;
                    }
                    else if (current > largest[i + 1])
                    {
                        continue;
                    }

                    return i;
                }
            }

            return -1;
        }

        public static void AddToLargestArray(int[] largest, int current)
        {
            var indexToAdd = FindIndexToInsert(largest, current);

            if (indexToAdd > -1)
            {
                switch (indexToAdd)
                {
                    case 0:
                        largest[0] = current;
                        break;
                    case 1:
                        largest[0] = largest[1];
                        largest[1] = current;
                        break;
                    case 2:
                        largest[0] = largest[1];
                        largest[1] = largest[2];
                        largest[2] = current;
                        break;
                }
            }
        }
    }
}
