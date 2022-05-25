namespace Algorithms.Strings
{
    internal class RomanToInteger
    {
        private static string subtractableI = "VX";
        private static string subtractableX = "LC";
        private static string subtractableC = "DM";

        public static int Convert(string number)
        {
            int value = 0;
            char previous = ' ';

            for (int i = number.Length - 1; i >= 0; i--)
            {
                var current = number[i];

                int partial = ConvertSingleNumber(number[i]);

                if (IsSubtraction(current, previous))
                {
                    partial = partial * -1;
                }

                previous = current;

                value += partial;
            }

            return value;
        }

        private static bool IsSubtraction(char current, char previous)
        {
            switch (current)
            {
                case 'I':
                    return subtractableI.Contains(previous);
                case 'X':
                    return subtractableX.Contains(previous);
                case 'C':
                    return subtractableC.Contains(previous);
                default:
                    return false;
            }
        }

        private static int ConvertSingleNumber(char number)
        {
            switch (number)
            {
                case 'I':
                    return 1;
                case 'V':
                    return 5;
                case 'X':
                    return 10;
                case 'L':
                    return 50;
                case 'C':
                    return 100;
                case 'D':
                    return 500;
                case 'M':
                    return 1000;
                default:
                    return 0;
            }
        }
    }
}
