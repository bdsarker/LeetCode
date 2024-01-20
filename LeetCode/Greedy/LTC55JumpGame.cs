using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Greedy
{
    internal class LTC55JumpGame
    {
        public static void Main(string[] args)
        {
            int[] nums = { 2, 3, 1, 1, 4 };

            Console.WriteLine(new LTC55JumpGame().CanJump(nums));
        }

        public bool CanJump(int[] nums)
        {
            int max = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                if (i > max) return false;

                max = Math.Max(max, i + nums[i]);
            }

            return true;
        }
    }
}
