using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Algorithms.DataStructures.BinarySearchTrees
{
    // Write a BST class for a Binary Search Tree.The class should support:
    //
    // Inserting values with the insert method.
    // Removing values with the remove method;
    // this method should only remove the first instance of a given value.
    //
    // Searching for values with the contains method.
    // Note that you can't remove values from a single-node tree.
    // In other words, calling the remove method on a single-node tree should simply not do anything.
   
    // Each BST node has an integer value, a left child node, and a right child node.
    // A node is said to be a valid BST node if and only if it satisfies the BST property:
    // its value is strictly greater than the values of every node to its left;
    // its value is less than or equal to the values of every node to its right;
    // and its children nodes are either valid BST nodes themselves or None / null.
   
    // Sample Usage
    // // Assume the following BST has already been created:
    //          10
    //        /     \
    //       5      15
    //     /   \   /   \
    //    2     5 13   22
    //  /           \
    // 1            14
    //
    // // All operations below are performed sequentially.
    // insert(12):   10
    //             /     \
    //            5      15
    //          /   \   /   \
    //         2     5 13   22
    //       /        /  \
    //      1        12  14
    //   
    // remove(10):   12
    //            /     \
    //           5      15
    //         /   \   /   \
    //        2     5 13   22
    //       /           \
    //      1            14\

    internal class BST
    {
        public int value;
        public BST left;
        public BST right;

        public BST(int value)
        {
            this.value = value;
        }

        public BST Insert(int value)
        {
            if (value >= this.value)
            {
                if (this.right == null)
                {
                    this.right = new BST(value);
                }
                else
                {
                    this.right.Insert(value);
                }
            }
            else if (value < this.value)
            {
                if (this.left == null)
                {
                    this.left = new BST(value);
                }
                else
                {
                    this.left.Insert(value);
                }
            }

            return this;
        }

        public bool Contains(int value)
        {
            if (value > this.value)
            {
                if (this.right != null)
                {
                    return this.right.Contains(value);
                }
            }
            else if (value < this.value)
            {
                if (this.left != null)
                {
                    return this.left.Contains(value);
                }
            }
            else if (value == this.value)
            {
                return true;
            }

            return false;
        }

        public BST Remove(int value)
        {
            if (value > this.value)
            {
                if (this.right != null)
                {
                    this.right = this.right.Remove(value);
                }
            }
            else if (value < this.value)
            {
                if (this.left != null)
                {
                    this.left = this.left.Remove(value);
                }
            }
            else
            {
                if (this.left == null && this.right == null)
                {
                    return null;
                }
                else if (this.left == null)
                {
                    this.value = this.right.value;
                    this.left = this.right?.left;
                    this.right = this.right?.right;
                }
                else if (this.right == null)
                {
                    this.value = this.left.value;
                    this.left = this.left?.left;
                    this.right = this.left?.right;
                }
                else
                {
                    // because is the smallest from the right subtree
                    BST smallest = this.right;
                    
                    while (smallest.left != null)
                    {
                        smallest = smallest.left;
                    }

                    this.value = smallest.value;
                    this.right = this.right.Remove(smallest.value);
                }
            }

            return this;
        }
    }
}
