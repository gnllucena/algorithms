using Algorithms.Structures;

namespace Algorithms.Trees
{
    // https://www.hackerrank.com/challenges/tree-height-of-a-binary-tree/problem
    // https://www.youtube.com/watch?v=D2cFSDfg0So
    //  O(n)
    internal class HeightOfABinaryTree
    {
        public static int Height(Tree root)
        {
            if (root == null)
            {
                return -1;
            }

            int leftSize = Height(root.Left);
            int rigthSize = Height(root.Right);

            if (leftSize > rigthSize)
            {
                return leftSize + 1;
            }
            else
            {
                return rigthSize + 1;
            }
        }

    }
}
