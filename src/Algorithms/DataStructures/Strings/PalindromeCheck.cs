using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DataStructures.Strings
{
    internal class PalindromeCheck
    {
        public static bool Problem(string text)
        {
            var leftPointer = 0;
            var rightPointer = text.Length - 1;

            return Recursion(text, leftPointer, rightPointer);
        }

        public static bool Recursion(string text, int leftPointer, int rightPointer)
        {
            if (leftPointer > rightPointer || rightPointer < leftPointer) 
            {
                return true;
            }

            if (text[leftPointer] == text[rightPointer])
            {
                return Recursion(text, leftPointer + 1, rightPointer - 1);
            }

            return false;
        }
    }
}
