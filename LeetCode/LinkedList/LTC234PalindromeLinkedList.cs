using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LinkedList
{
    internal class LTC234PalindromeLinkedList
    {
        // Main function to run the test cases
        public static void Main()
        {
            var head = new ListNode(1);
            
            var node = new ListNode(2);
            head.next = node;
            node=head.next;

            node = new ListNode(2);
            head.next = node;
            node = head.next;
            

            var obj = new LTC234PalindromeLinkedList();
            var result = obj.IsPalindrome(head);
            Console.WriteLine(result);
        }
        public bool IsPalindrome(ListNode head)
        {
            var slow = head;
            var fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            if (fast != null)
                slow = slow.next;

            slow = Reverse(slow);
            fast = head;

            while (slow != null)
            {
                if (slow.val != fast.val)
                    return false;
                slow = slow.next;
                fast = fast.next;
            }

            return true;
        }

        private ListNode Reverse(ListNode head)
        {
            ListNode prev = null;
            while (head != null)
            {
                var next = head.next;
                head.next = prev;
                prev = head;
                head = next;
            }

            return prev;
        }
    }
}
