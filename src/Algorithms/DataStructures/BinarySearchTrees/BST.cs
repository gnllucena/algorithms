using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DataStructures.BinarySearchTrees
{
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
