using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LTC75
{
    internal class LTC643MaximumAverageSubarrayI
    {
        //Main method to execute the code
        public static void Main(string[] args)
        {
            int[] nums = { 1, 12, -5, -6, 50, 3 };
            int k = 4;
            Console.WriteLine(new LTC643MaximumAverageSubarrayI().FindMaxAverage(nums, k));
            Console.ReadLine();
        }

        public double FindMaxAverage(int[] nums, int k)
        {
            int sum = 0;
            for (int i = 0; i < k; i++)
            {
                sum += nums[i];
            }
    
            int maxSum = sum;
            for (int i = k; i < nums.Length; i++)
            {
                sum += nums[i] - nums[i - k];
                maxSum = Math.Max(maxSum, sum);
            }
            
            return (double)maxSum / k;
        }
    
    }
}
