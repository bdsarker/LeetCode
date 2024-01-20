using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LTC75
{
    internal class LTC283MoveZeroes
    {
        //implement the main method here to run the test case
        public static void Main(string[] args)
        {
            int[] nums = new int[] { 0, 0, 0, 3, 12 };
                new LTC283MoveZeroes().MoveZeroes(nums);
                Console.ReadLine();
            }

        public void MoveZeroes(int[] nums)
        {
            int right = 0;
            int left = 0;

            while (right < nums.Length)
            {
                if (nums[right] != 0)
                    nums[left++] = nums[right];
                right++;
            }

            while (left < nums.Length)
                nums[left++] = 0;
                
        }
    }
}
