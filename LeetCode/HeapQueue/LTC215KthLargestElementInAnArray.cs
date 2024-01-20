using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HeapQueue
{
    internal class LTC215KthLargestElementInAnArray
    {
        public static void Main(string[] args)
        {
            int[] nums = { 3, 2, 1, 5, 6, 4 };
            int k = 2;
            Console.WriteLine(new LTC215KthLargestElementInAnArray().FindKthLargest(nums, k));
        }

        public int FindKthLargest(int[] nums, int k)
        {
            PriorityQueue<int, int> queue = new PriorityQueue<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                if (queue.Count < k)
                    queue.Enqueue(nums[i], nums[i]);
                else
                {
                    if (nums[i] <= queue.Peek()) continue;

                    queue.Dequeue();
                    queue.Enqueue(nums[i], nums[i]);
                }
            }
            return queue.Peek();
        }
    
    }
}
