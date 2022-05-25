using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LinkedList
{
    internal class AddTwoNumber
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public static ListNode Add(ListNode l1, ListNode l2)
        {
            int carry = 0;
            ListNode foo = new ListNode(0);
            var current = foo;

            while (l1 != null || l2 != null)
            {
                var l1Value = l1 != null ? l1.val : 0;
                var l2Value = l2 != null ? l2.val : 0;

                var sum = l1Value + l2Value + carry;

                carry = sum / 10;

                current.next = new ListNode(sum % 10);

                current = current.next;

                if (l1 != null)
                {
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    l2 = l2.next;
                }
            }

            if (carry > 0)
            {
                current.next = new ListNode(carry);
            }

            return foo.next;
        }
    }
}
