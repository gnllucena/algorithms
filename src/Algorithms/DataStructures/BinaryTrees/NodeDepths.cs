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
            var items = new List<int>();
             
            var result = Find(root, 0, items);

            return result.Sum(x => x);
        }

        public static List<int> Find(BT node, int sum, List<int> items)
        {
            if (node.left != null)
            {
                Find(node.left, sum, items);
            }

            if (node.right != null)
            {
                Find(node.right, sum, items);
            }

            if (node.left == null && node.right == null)
            {
                items.Add(sum);
            }

            return items;
        }
    }
}
