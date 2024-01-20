using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LinkedList
{
    internal class LTC19RemoveNthNodeFromEndofList
    {
        // main method with 
        public static void Main(string[] args)
        {
            ListNode head = new ListNode(1);
            ListNode node1 = new ListNode(2);
            ListNode node2 = new ListNode(3);
            ListNode node3 = new ListNode(4);
            ListNode node4 = new ListNode(5);

            head.next = node1;
            node1.next = node2;
            node2.next = node3;
            node3.next = node4;

            LTC19RemoveNthNodeFromEndofList removeNthNodeFromEndofList = new LTC19RemoveNthNodeFromEndofList();
            ListNode result = removeNthNodeFromEndofList.RemoveNthFromEnd(head, 2);

            while (result != null)
            {
                Console.Write(result.val + " ");
                result = result.next;
            }
        }

        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (head == null)
                return null;

            ListNode dummy = new ListNode(0);
            dummy.next = head;

            ListNode slow = dummy;
            ListNode fast = dummy;

            for (int i = 0; i < n; i++)
            {
                fast = fast.next;
            }

            while (fast.next != null)
            {
                slow = slow.next;
                fast = fast.next;
            }

            slow.next = slow.next.next;

            return dummy.next;
        }
    }
}
