using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LTC75
{
    internal class LTC724FindPivotIndex
    {
        //main method to execute the code
        public static void Main(string[] args)
        {
            int[] nums = { 1, 7, 3, 6, 5, 6 };
            Console.WriteLine(new LTC724FindPivotIndex().PivotIndex(nums));
            Console.ReadLine();
        }
        public int PivotIndex(int[] nums)
        {
            int sum = nums.Sum();
            int leftSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (leftSum == sum - leftSum - nums[i])
                {
                    return i;
                }
                leftSum += nums[i];
            }
            return -1;
        }
    }
}
