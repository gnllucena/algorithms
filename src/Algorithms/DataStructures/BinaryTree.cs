using Algorithms.DataStructures.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Security.Principal;
using Algorithms.DataStructures.BinaryTrees;
using static Algorithms.DataStructures.BinaryTrees.BranchSums;

namespace Algorithms.DataStructures.BinaryTree
{

    // tree =     1
    //         /     \
    //        2       3
    //      /   \    /  \
    //     4     5  6    7
    //   /   \  /
    //  8    9 10
    // read as = 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
    internal class BinaryTree
    {
        public static void Green()
        {
            //Console.WriteLine("BranchSums");
            //var array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var binaryTree = BT.InsertInOrder(array, 0);

            //var result = BranchSums.Problem(binaryTree);

            Console.WriteLine("BranchSums");
            var array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var binaryTree = BT.InsertInOrder(array, 0);

            var result = NodeDepths.Problem(binaryTree);
        }

        public static void Blue()
        {
        }
    }
}
