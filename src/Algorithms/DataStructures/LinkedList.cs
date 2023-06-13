using Algorithms.DataStructures.LinkedLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DataStructures
{
    internal class LinkedList
    {
        public static void Green()
        {
            Console.WriteLine("RemoveDuplicatesFromLinkedList");

            var lk = new RemoveDuplicatesFromLinkedList.LinkedList(1);
            lk.next = new RemoveDuplicatesFromLinkedList.LinkedList(1);
            lk.next.next = new RemoveDuplicatesFromLinkedList.LinkedList(3);
            lk.next.next.next = new RemoveDuplicatesFromLinkedList.LinkedList(4);
            lk.next.next.next.next = new RemoveDuplicatesFromLinkedList.LinkedList(4);
            lk.next.next.next.next.next = new RemoveDuplicatesFromLinkedList.LinkedList(4);
            lk.next.next.next.next.next.next = new RemoveDuplicatesFromLinkedList.LinkedList(5);
            lk.next.next.next.next.next.next.next = new RemoveDuplicatesFromLinkedList.LinkedList(6);
            lk.next.next.next.next.next.next.next.next = new RemoveDuplicatesFromLinkedList.LinkedList(6);

            RemoveDuplicatesFromLinkedList.Problem(lk);

            var i = 0;
        }
    }
}
