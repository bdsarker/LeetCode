using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.TwoPointer
{
    internal class LTC2824CountPairsWhoseSumIsLessThanTarget
    {
        // Write Main method here to call and test your solution
        internal static void Main()
        
        {
            int[] nums = { -1, 1, 2, 3, 1 };
            int target = 2;
            Console.WriteLine(CountPairsWhoseSumIsLessThanTarget(nums, target));
        }

        internal static int CountPairsWhoseSumIsLessThanTarget(IList<int> nums, int target)
        {
            int count = 0;
            int left = 0;
            int right = nums.Count - 1;
            nums = nums.OrderBy(x => x).ToList();
            
            while (left < right)
            {
                if (nums[left] + nums[right] < target)
                {
                    count += right - left;
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return count;

        }
    }
}
