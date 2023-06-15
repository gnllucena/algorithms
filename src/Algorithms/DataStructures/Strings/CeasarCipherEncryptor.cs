using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DataStructures.Strings
{
    internal class CeasarCipherEncryptor
    {
        public static string Problem(string str, int key)
        {
            key = key % 26;

            // 26 letters
            string alphabet = "abcdefghijklmnopqrstuvwxyz";

            var newString = "";

            foreach (var character in str)
            {
                var index = alphabet.IndexOf(character);

                var newLetterIndex = index + key;

                if (newLetterIndex > 25)
                {
                    // -1 because the alphabet has 26 letters,
                    // and the array has 25 positions (it starts with 0)
                    newLetterIndex = newLetterIndex - 26 + key - 2; 
                }

                newString += alphabet[newLetterIndex];
            }

            return newString;
        }
    }
}
