using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LTC75
{
    internal class LTC238ProductOfArrayExcepSelf
    {
        // Main method to execute the code
        public static void Main(string[] args)
        {
            int[] nums = new int[] { 5, 2, 3, 4 };
            int[] result = new LTC238ProductOfArrayExcepSelf().ProductExceptSelf(nums);
            
            foreach (int i in result)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] result = new int[nums.Length];
            int[] left = new int[nums.Length];
            int[] right = new int[nums.Length];
            
            left[0] = 1;

            right[nums.Length - 1] = 1;
            
            for (int i = 1; i < nums.Length; i++)
            {
                left[i] = left[i - 1] * nums[i - 1];
                right[nums.Length - 1 - i] = right[nums.Length - i] * nums[nums.Length - i];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = left[i] * right[i];
            }
            return result;
        }
    }
}
