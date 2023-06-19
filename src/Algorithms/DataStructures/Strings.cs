using Algorithms.DataStructures.Searching;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DataStructures.Strings
{
    internal class Strings
    {
        public static void Green()
        {
            Console.WriteLine("Palindrome Check");
            // var result = PalindromeCheck.Problem("abcdcba");

            Console.WriteLine("Ceasar Cipher Encryptor");
            //var result = CeasarCipherEncryptor.Problem("xyz", 2);

            Console.WriteLine("Run Length Encoding");
            //var result = RunLenghtEncoding.Problem("AAAAAAAAAAAAABBCCCCDD");

            Console.WriteLine("Common Characters");
            //var result = CommonCharacters.Problem(new string[] { "abc", "bcd", "cbad" });

            Console.WriteLine("Generate Document");
            //var result = GenerateDocument.Problem("A", "a");

            Console.WriteLine("First non repeating character");
            var result = FirstNonRepeatingCharacter.Problem("ababac");
        }
    }
}
