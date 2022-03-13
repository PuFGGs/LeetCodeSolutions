using _0002_AddTwoNumbers.Model;
using System;

namespace _0002_AddTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode l1 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))));
            ListNode l2 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))));
            Solution solution = new Solution();
            solution.AddTwoNumbers(l1, l2);
        }
    }
}
