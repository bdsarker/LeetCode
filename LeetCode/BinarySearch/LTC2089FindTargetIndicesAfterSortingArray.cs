using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BinarySearch
{
    internal class LTC2089FindTargetIndicesAfterSortingArray
    {
        // main method to test the code 
        public static void Main()
        {
            int[] nums = new int[] { 1, 2, 3, 4, 5, 5, 5, 5, 6 };
            int target = 5;
            Console.WriteLine(string.Join(", ", new LTC2089FindTargetIndicesAfterSortingArray().TargetIndices(nums, target)));
        }

        public IList<int> TargetIndices(int[] nums, int target)
        {
            Array.Sort(nums);
            
            var result = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                    result.Add(i);
            }
            return result;
        }
    }
}
