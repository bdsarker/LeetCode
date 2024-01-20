using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LinkedList
{
    internal class LTC206ReverseLinkedList
    {
        public static void Main(string[] args)
        {
            // ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
            // what are alternate ways to create a linked list?
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);


            ListNode result = ReverseList(head);

            while (result != null)
            {
                Console.Write(result.val + " ");
                result = result.next;
            }
        }


        public static ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            while (head != null)
            {
                ListNode temp = head.next;
                head.next = prev;
                prev = head;
                head = temp;
            }
            return prev;
        }

    }
}
