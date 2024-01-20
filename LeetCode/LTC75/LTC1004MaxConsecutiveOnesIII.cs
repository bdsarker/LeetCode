using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LTC75
{
    internal class LTC1004MaxConsecutiveOnesIII
    {
        // Main method to test the code
        
        public static void Main(string[] args)
        {
            int[] A = { 1, 1, 1, 0, 0, 0, 1, 1, 1, 1 };
            int K = 2;

            Console.WriteLine(new LTC1004MaxConsecutiveOnesIII().LongestOnes(A, K));
        }

        public int LongestOnes(int[] nums, int k)
        {
            int max = 0; // max length of subarray
            
            int left = 0; // left pointer
            int right = 0; // right pointer
            
            int count = 0; // count of 0s in the subarray
 
            while (right < nums.Length) 
            {
                if (nums[right] == 0) // if the right pointer is 0, increase the count
                {
                    count++;
                }

                while (count > k) // if the count is greater than k, move the left pointer
                {
                    if (nums[left] == 0) // if the left pointer is 0, decrease the count
                    {
                        count--;
                    }

                    left++;
                }

                max = Math.Max(max, right - left + 1);
                right++;
            }

            return max;
        }
    }

}
