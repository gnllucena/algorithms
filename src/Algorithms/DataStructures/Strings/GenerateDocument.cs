using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Algorithms.DataStructures.Strings
{
    public class GenerateDocument
    {
        public static bool Problem(string characters, string document)
        {
            var hashChars = new Dictionary<char, int>();
            var hashDocument = new Dictionary<char, int>();

            foreach (char c in characters)
            {
                if (hashChars.ContainsKey(c))
                {
                    hashChars[c]++;
                }
                else
                {
                    hashChars.Add(c, 1);
                }
            }

            foreach (char c in document)
            {
                if (hashDocument.ContainsKey(c))
                {
                    hashDocument[c]++;
                } 
                else
                {
                    hashDocument.Add(c, 1);
                }
            }


            foreach (var item in hashDocument) 
            { 
                if (!hashChars.ContainsKey(item.Key) || item.Value > hashChars[item.Key])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
