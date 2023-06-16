using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DataStructures.Strings
{
    public class RunLenghtEncoding
    {
        public static string Problem(string str)
        {
            char current = ' ';

            var count = 0;
            var encoding = string.Empty;

            for (var i = 0; i < str.Length; i++)
            {
                var newCharacter = str[i];

                if (newCharacter != current)
                {
                    if (count != 0)
                    {
                        encoding += $"{count}{current}";

                        count = 1;
                    }
                    else
                    {
                        count++;
                    }

                    current = newCharacter;
                }
                else if (count == 9)
                {
                    encoding += $"{count}{current}";

                    count = 1;
                }
                else
                {
                    count++;
                }
            }

            return encoding += $"{count}{current}";
        }
    }
}
