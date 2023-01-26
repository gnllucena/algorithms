using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DataStructures.BinaryTrees
{
    internal class BT
    {
        public int value;
        public BT left;
        public BT right;

        public BT(int value)
        {
            this.value = value;
            this.left = null;
            this.right = null;
        }

        public static BT InsertInOrder(int[] array, int level)
        {
            BT tree = null;

            if (level < array.Length)
            {
                tree = new BT(array[level]);

                tree.left = InsertInOrder(array, 2 * level + 1);

                tree.right = InsertInOrder(array, 2 * level + 2);
            }

            return tree;
        }
    }
}
