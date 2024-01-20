using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LTC75
{
    internal class LTC1493LongestSubarrayOf1AfterDeletingOneElement
    {
        // Main method to run the test cases
        public static void Main(string[] args)
        {
            Console.WriteLine("LTC1493LongestSubarrayOf1AfterDeletingOneElement");
            LTC1493LongestSubarrayOf1AfterDeletingOneElement sol = new LTC1493LongestSubarrayOf1AfterDeletingOneElement();

            int[] nums = new int[] { 0, 1, 1, 1, 0, 1, 1, 0, 1 };
            Console.WriteLine(sol.LongestSubarray(nums));
        }
        public int LongestSubarray(int[] nums)
        {
            int max = 0;
            int left = 0;
            int right = 0;
            int count = 0;
            while (right < nums.Length)
            {
                if (nums[right] == 0)
                {
                    count++;
                }

                while (count > 1)
                {
                    if (nums[left] == 0)
                    {
                        count--;
                    }
                    left++;
                }
                max = Math.Max(max, right - left);
                right++;
            }
            return max;
        }
    }
}
