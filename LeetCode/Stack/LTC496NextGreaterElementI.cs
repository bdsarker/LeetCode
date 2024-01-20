using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Stack
{
    internal class LTC496NextGreaterElementI
    {
        // Write a main method to test.
        public static void Main()
        {
            var nums1 = new int[] { 4, 1, 2 };
            var nums2 = new int[] { 1, 3, 4, 2, 7 };
            var result = new LTC496NextGreaterElementI().NextGreaterElement(nums1, nums2);
            foreach (var num in result)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            var dict = new Dictionary<int, int>();
            var stack = new Stack<int>();
    
            foreach (var num in nums2)
            {
                while (stack.Count > 0 && stack.Peek() < num)
                {
                    dict.Add(stack.Pop(), num);
                }
                stack.Push(num);
            }

            var result = new int[nums1.Length];
            for (int i = 0; i < nums1.Length; i++)
            {
                result[i] = dict.ContainsKey(nums1[i]) ? dict[nums1[i]] : -1;
            }
            return result;
        }
    
    }
}
