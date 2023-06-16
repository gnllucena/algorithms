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
            // 26 letters
            string alphabet = "abcdefghijklmnopqrstuvwxyz";

            var newString = "";

            foreach (var character in str)
            {
                var index = alphabet.IndexOf(character);

                var newIndex = (index + key) % 26;

                newString += alphabet[newIndex];
            }

            return newString;
        }
    }
}
