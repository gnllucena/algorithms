using Algorithms.Structures;

namespace Algorithms.Trees
{
    // https://www.hackerrank.com/challenges/tree-level-order-traversal/problem
    // https://www.youtube.com/watch?v=gcR28Hc2TNQ
    // O(n)
    internal class LevelOrderTraversal
    {   
        public static string LevelTraverse(Tree root)
        {
            var queue = new Queue<Tree>();

            var response = string.Empty;

            if (root == null)
            {
                return response;
            }

            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();

                response += $"{current.Data} ";

                if (current.Left != null)
                {
                    queue.Enqueue(current.Left);
                }

                if (current.Right != null)
                {
                    queue.Enqueue(current.Right);
                }
            }

            return response;
        }
    }
}
