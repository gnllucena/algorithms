using Algorithms.Auxiliar.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Hashtable
{
    internal class TwoSum
    {
        public static int[] Find(List<int> nums, int target)
        {
            var result = new int[2];

            var dictionary = new Dictionary<int, int>();

            for (int i = 0; i < nums.Count(); i++)
            {
                var current = nums[i];

                var contains = dictionary.ContainsKey(target - current);

                if (!contains)
                {
                    if (!dictionary.ContainsKey(current))
                    {
                        dictionary.Add(current, i);    
                    }
                }
                else
                {
                    result[0] = dictionary[target - current];
                    result[1] = i;

                    break;
                }
            }

            return result;
        }
    }
}
