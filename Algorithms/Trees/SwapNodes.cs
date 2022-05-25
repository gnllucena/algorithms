using Algorithms.Structures;

namespace Algorithms.Trees
{
    // https://www.hackerrank.com/challenges/swap-nodes-algo/problem
    // https://www.youtube.com/watch?v=5dySuyZf9Qg
    // https://rusyasoft.github.io/competitive%20programming/2018/07/24/hrank-swapNodes/ (explicação)
    // O(n.m.x) ==  O(n)
    internal class SwapNodes
    {
        public static List<List<int>> Swap(List<List<int>> indexes, List<int> queries)
        {
            var tree = new Tree(1, 1);

            tree = Build(tree, indexes);

            return Queries(tree, queries);
        }

        private static Tree Build(Tree tree, List<List<int>> indexes)
        {
            // BFS pra transformar a matrix em tree
            var queue = new Queue<Tree>();
            queue.Enqueue(tree);

            var aux = 0;
            while (aux < indexes.Count)
            {
                var current = queue.Dequeue();

                var a = indexes[aux][0];
                var b = indexes[aux][1];

                if (a != -1)
                {
                    current.Left = new Tree(a, current.Depth + 1);
                    queue.Enqueue(current.Left);
                }

                if (b != -1)
                {
                    current.Right = new Tree(b, current.Depth + 1);
                    queue.Enqueue(current.Right);
                }

                aux++;
            }

            return tree;
        }

        private static void Swap(Tree tree, int k)
        {
            var queue = new Queue<Tree>();
            queue.Enqueue(tree);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                
                if (current.Depth % k == 0)
                {
                    var newLeft = current.Right;
                    var newRight = current.Left;

                    current.Left = newLeft;
                    current.Right = newRight;
                }

                if (current.Left != null)
                {
                    queue.Enqueue(current.Left);
                }

                if (current.Right != null)
                {
                    queue.Enqueue(current.Right);
                }
            }
        }


        private static List<List<int>> Queries(Tree tree, List<int> queries)
        {
            var all = new List<List<int>>();

            for (var i = 0; i < queries.Count; i++)
            {
                Swap(tree, queries[i]);

                var result = new List<int>();
                
                InOrderTraverse(tree, result);

                all.Add(result);
            }

            return all;
        }

        private static List<int> InOrderTraverse(Tree tree, List<int> result)
        {
            if (tree == null)
            {
                return result;
            }

            InOrderTraverse(tree.Left, result);
            result.Add(tree.Data);
            InOrderTraverse(tree.Right, result);

            return result;
        }
    }
}
