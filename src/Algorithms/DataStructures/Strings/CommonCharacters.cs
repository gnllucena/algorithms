using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Algorithms.DataStructures.Strings
{
    public class CommonCharacters
    {
        public static string[] Problem(string[] strings)
        {
            var result = new List<string>();
            var dictionary = new Dictionary<object, int>();

            foreach (var item in strings) 
            {
                var set = new HashSet<char>(item.ToCharArray());

                foreach (var character in set)
                {
                    if (dictionary.ContainsKey(character))
                    {
                        dictionary[character] += 1;
                    } 
                    else
                    {
                        dictionary.Add(character, 1);
                    }
                }
            }

            var itemsCount = strings.Length;

            foreach (var item in dictionary)
            {
                if (item.Value == itemsCount)
                {
                    result.Add(item.Key.ToString());
                }
            }

            return result.ToArray();
        }
    }
}
