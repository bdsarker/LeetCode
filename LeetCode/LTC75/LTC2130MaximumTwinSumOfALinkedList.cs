using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LTC75
{
    internal class LTC2130MaximumTwinSumOfALinkedList
    {
        //Main function to test the code
        public static void Main(string[] args)
        {
            ListNode head = new(1, new(2, new(3, new(4))));
            Console.WriteLine(new LTC2130MaximumTwinSumOfALinkedList().PairSum(head));
        }
        public int PairSum(ListNode head)
        {
            ListNode l1 = head, l2 = head;
            
            Stack<int> s1 = new();
            
            while (l2 != null)
            {
                s1.Push(l1.val);
                l1 = l1.next;
                l2 = l2.next.next;
            }

            int max = 0;
            while (s1.Count > 0)
            {
                max = Math.Max(max, s1.Pop() + l1.val);
                l1 = l1.next;
            }
            return max;
        }
    }
}
