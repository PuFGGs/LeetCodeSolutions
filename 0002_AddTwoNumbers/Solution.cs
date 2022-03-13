using _0002_AddTwoNumbers.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0002_AddTwoNumbers
{
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var carried = 0;
            var result = new ListNode();
            var curr = result;
            while (l1 != null && l2 != null)
            {
                carried = Sum(l1.val, l2.val, carried);
                l1 = l1.next;
                l2 = l2.next;
            }

            while (l1 != null)
            {
                carried = Sum(l1.val, 0, carried);
                l1 = l1.next;
            }

            while (l2 != null)
            {
                carried = Sum(l2.val, 0, carried);
                l2 = l2.next;
            }

            if (carried > 0)
                curr.next = new ListNode(carried);

            return result.next;

            int Sum(int a, int b, int c)
            {
                var sum = a + b + c;
                curr.next = new ListNode(sum % 10);
                curr = curr.next;
                return sum / 10;
            }
        }
    }
}
