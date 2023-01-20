using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Algorithms.DataStructures.BinarySearchTrees
{
    internal class FindClosestValueInBST
    {


        // Write a function that takes in a Binary Search Tree(BST)
        // and a target integer value and returns the closest value to that target value contained in the BST.
        // You can assume that there will only be one closest value.
        // Each BST node has an integer value, a left child node, and a right child node.
        // A node is said to be a valid BST node if and only if it satisfies the BST property:
        // its value is strictly greater than the values of every node to its left;
        // its value is less than or equal to the values of every node to its right;
        // and its children nodes are either valid BST nodes themselves or None / null.
        //
        // Sample Input
        // tree =   10
        //        /     \
        //       5      15
        //     /   \   /   \
        //    2     5 13   22
        //  /           \
        // 1            14
        // target = 12
        // Sample Output
        // 13
        public static int Problem(BST tree, int target)
        {
            return Find(tree, target, tree.value);
        }

        public static int Find(BST tree, int target, int closest)
        {
            var differenceCurrent = tree.value - target;
            var differenceClosest = closest - target;

            if (Math.Abs(differenceCurrent) < Math.Abs(differenceClosest))
            {
                closest = tree.value;
            }

            if (target > tree.value)
            {
                if (tree.right != null)
                {
                    return Find(tree.right, target, closest);
                }

                return closest;
            }
            else if (target < tree.value)
            {
                if (tree.left != null)
                {
                    return Find(tree.left, target, closest);
                }

                return closest;
            }

            return tree.value;
        }
    }
}
