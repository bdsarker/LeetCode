using LeetCode.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LTC75
{

    // Linklist class


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

    public class LTC2095DeleteTheMiddleNodeOfLinkedList
    {


        // main function to delete middle node
        public static void Main(string[] args)
        {
            ListNode head = null;
            head = new ListNode(1);


            Console.WriteLine("Given Linked List");
            PrintList(head);

            head = DeleteMiddle(head);

            Console.WriteLine("Linked List after deletion of middle");
            PrintList(head);
        }

        public static void PrintList(ListNode head)
        {
            while (head != null)
            {
                Console.Write(head.val + " "); 
                head = head.next;
            } 
            Console.WriteLine();
        }

        public static ListNode DeleteMiddle(ListNode head)
        {
            if (head.next == null)
            {
                return head;
            }

            ListNode slow = head;
            ListNode fast = head;
            ListNode prev = null;

            while (fast != null && fast.next != null)
            {
                prev = slow;
                slow = slow.next;
                fast = fast.next.next;
            }

            prev.next = slow.next;
            return head;
        }
    }
}
