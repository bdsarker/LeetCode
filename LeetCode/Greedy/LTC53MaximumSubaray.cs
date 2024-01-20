using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Greedy
{
    internal class LTC53MaximumSubaray
    {
        public static void Main(string[] args)
        {
            int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };

            Console.WriteLine(new LTC53MaximumSubaray().MaxSubArray(nums));
        }

        public int MaxSubArray(int[] nums)
        {
            int max = nums[0];
            int sum = nums[0];

            for (var i = 1; i < nums.Length; i++)
            {
                sum = Math.Max(nums[i], sum + nums[i]);
                max = Math.Max(max, sum);
            }

            return max;
        }
    }
}
