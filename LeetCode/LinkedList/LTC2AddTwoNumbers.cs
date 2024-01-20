using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LinkedList
{
    internal class LTC2AddTwoNumbers
    {
        // main methos with sample input
        public static void Main(string[] args) { 
            // create list 1 and 2
            ListNode l1 = new ListNode(2);
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(3);

            ListNode l2 = new ListNode(5);
            l2.next = new ListNode(6);
            l2.next.next = new ListNode(4);

            // call addTwoNumbers method
            ListNode result = new LTC2AddTwoNumbers().AddTwoNumbers(l1, l2);

            //Print result
            while (result != null)
            {
                Console.Write(result.val + " ");
                result = result.next;
            }
        }
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode(0);
            ListNode current = result;
            int carry = 0;
            while (l1 != null || l2 != null)
            {
                int sum = carry;
                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }
                current.next = new ListNode(sum % 10);
                current = current.next;
                carry = sum / 10;
            }
            if (carry > 0)
            {
                current.next = new ListNode(carry);
            }
            return result.next;
        }
    }
}
