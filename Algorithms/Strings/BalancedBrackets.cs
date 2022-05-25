namespace Algorithms.Strings
{
    internal class BalancedBrackets
    {
        // https://www.hackerrank.com/challenges/balanced-brackets/problem
        // https://www.youtube.com/watch?v=CCyEXcNamC4
        public static bool IsBalanced(string text)
        {
            var opened = "[{(";
            var closed = "]})";

            var stack = new Stack<char>();

            foreach (var charactere in text)
            {
                if (opened.Contains(charactere))
                {
                    stack.Push(charactere);
                }
                else if (closed.Contains(charactere))
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    var last = stack.Pop();

                    if (!IsMatch(last, charactere))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }

        private static bool IsMatch(char lastOnStack, char actualChar)
        {
            switch (lastOnStack)
            {
                case '(':
                    return actualChar == ')';
                case '{':
                    return actualChar == '}';
                case '[':
                    return actualChar == ']';
            }

            return false;
        }
    }
}
