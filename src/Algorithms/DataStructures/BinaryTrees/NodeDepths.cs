using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DataStructures.BinaryTrees
{
    internal class NodeDepths
    {
        public static int Problem(BT root)
        {
            return Find(root, 0, 0);
        }

        public static int Find(BT node, int sum, int depth)
        {
            sum += depth;

            if (node.left != null)
            {
                sum = Find(node.left, sum, depth + 1);
            }

            if (node.right != null)
            {
                sum = Find(node.right, sum, depth + 1);
            }

            return sum;
        }
    }
}
