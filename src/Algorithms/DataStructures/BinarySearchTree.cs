using Algorithms.DataStructures.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Security.Principal;
using Algorithms.DataStructures.BinarySearchTrees;

namespace Algorithms.DataStructures
{
    internal class BinarySearchTree
    {
        public static void Green()
        {
            Console.WriteLine("FindClosestValueInBST");
            // tree =  10
            //       /    \
            //      5      15
            //    /   \   /  \
            //   2     5 13   22
            //  /         \
            // 1           14
            // read as = 10, 15, 22, 13, 14, 5, 5, 2, 1
            //var bst = new (int value, int? left, int? right)[]
            //{
            //    (10, 5, 15),
            //    (15, 13, 22),
            //    (22, null, null),
            //    (13, null, 14),
            //    (14, null, null),
            //    (5, 2, 5),
            //    (5, null, null),
            //    (2, 1, null),
            //    (1, null, null)
            //};

            //BST? tree = null;
            //tree = Fill(bst);

            //var target = 12;
            //var result = FindClosestValueInBST.Problem(tree, target);
        }

        public static void Blue()
        {
            Console.WriteLine("BSTConstruction");
            // tree =  10
            //       /    \
            //      5      15
            //    /   \   /  \
            //   2     5 13   22
            //  /         \
            // 1           14
            // read as = 10, 15, 22, 13, 14, 5, 5, 2, 1
            //var bst = new BST(10);
            //bst = bst.Insert(15);
            //bst = bst.Insert(22);
            //bst = bst.Insert(13);
            //bst = bst.Insert(14);
            //bst = bst.Insert(5);
            //bst = bst.Insert(5);
            //bst = bst.Insert(2);
            //bst = bst.Insert(1);

            //var contains = bst.Contains(2);

            //bst = bst.Remove(10);

            var bst = new BST(10);
            bst = bst.Insert(5);
            bst = bst.Remove(10);
            var contains = bst.Contains(15);

            var i = 0;
        }
    }
}
