using Algorithms.DataStructures.BinarySearchTrees;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Algorithms.DataStructures.BinaryTrees
{
    // The distance between a node in a Binary Tree and the tree's root is called the node's depth.

    // Write a function that takes in a Binary Tree and returns the sum of its nodes' depths.

    // Each BinaryTree node has an integer value, a left child node, and a right child node.
    // Children nodes can either be BinaryTree nodes themselves or None / null.

    // Sample Input
    // tree =    1
    //        /     \
    //       2       3
    //     /   \   /   \
    //    4     5 6     7
    //  /   \
    // 8     9
    // Sample Output
    // 16
    // The depth of the node with value 2 is 1.
    // The depth of the node with value 3 is 1.
    // The depth of the node with value 4 is 2.
    // The depth of the node with value 5 is 2.
    // Etc..
    // Summing all of these depths yields 16.
    internal class BranchSums
    {
        public static List<int> Problem(BT root)
        {
            var items = new List<int>();

            return Find(root, 0, items);
        }

        public static List<int> Find(BT node, int sum, List<int> items)
        {
            sum += node.value;

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
