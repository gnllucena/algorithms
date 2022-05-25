namespace Algorithms.Strings
{
    // O(n.m) == O(n)
    internal class PalindromeNumber
    {
        public static bool Check(int x)
        {
            var text = x.ToString();

            var stack = new Stack<char>();
            var queue = new Queue<char>();

            for (int i = 0; i < text.Length; i++)
            {
                stack.Push(text[i]);
                queue.Enqueue(text[i]);
            }

            for (int i = 0; i < text.Length; i++)
            {
                var lifo = stack.Pop();
                var fifo = queue.Dequeue();

                if (lifo != fifo)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
