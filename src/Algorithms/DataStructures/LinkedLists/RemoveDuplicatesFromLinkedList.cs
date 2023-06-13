using Algorithms.DataStructures.LinkedLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DataStructures.LinkedLists
{
    internal class RemoveDuplicatesFromLinkedList
    {
        public class LinkedList
        {
            public int value;
            public LinkedList next;

            public LinkedList(int value)
            {
                this.value = value;
                this.next = null;
            }
        }

        public static LinkedList Problem(LinkedList linkedList)
        {
            var current = linkedList;

            while (current != null)
            {
                if (current.value == current.next?.value)
                {
                    current.next = current.next.next;
                }
                else
                {
                    current = current.next;
                }
            }

            return linkedList;
        }
    }
}
