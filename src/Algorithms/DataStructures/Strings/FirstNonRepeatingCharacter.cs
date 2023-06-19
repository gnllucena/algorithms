using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Algorithms.DataStructures.Strings
{
    public class FirstNonRepeatingCharacter
    {
        public static int Problem(string str)
        {
            var dictionary = new Dictionary<char, int>();
        
            foreach (char c in str)
            {
                if (!dictionary.ContainsKey(c))
                {
                    dictionary.Add(c, 0);
                }

                dictionary[c]++;
            }

            foreach (var item in dictionary)
            {
                if (item.Value == 1)
                {
                    return str.IndexOf(item.Key);
                }
            }

            return -1;
        }
    }
}
