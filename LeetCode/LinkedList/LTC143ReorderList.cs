using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LinkedList
{
    internal class LTC143ReorderList
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

            LTC143ReorderList reorderList = new LTC143ReorderList();
            reorderList.ReorderList(head);

            while (head != null)
            {
                Console.Write(head.val + " ");
                head = head.next;
            }
        }
        public void ReorderList(ListNode head)
        {
            if (head == null || head.next == null)
                return;

            // find the middle node
            ListNode slow = head;
            ListNode fast = head;
            ListNode prev = null;

            while (fast != null && fast.next != null)
            {
                prev = slow;
                slow = slow.next;
                fast = fast.next.next;
            }

            // break the list into two
            prev.next = null;

            // reverse the second list
            ListNode second = Reverse(slow);

            // merge the two lists
            ListNode first = head;
            while (first != null && second != null)
            {
                ListNode temp1 = first.next;
                ListNode temp2 = second.next;

                first.next = second;
                second.next = temp1;

                first = temp1;
                second = temp2;
            }
        }

        private ListNode Reverse(ListNode head)
        {
            ListNode prev = null;
            ListNode curr = head;
            ListNode next = null;

            while (curr != null)
            {
                next = curr.next;
                curr.next = prev;

                prev = curr;
                curr = next;
            }

            return prev;
        }
    
    }
}
