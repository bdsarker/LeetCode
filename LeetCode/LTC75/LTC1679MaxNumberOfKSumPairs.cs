using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LTC75
{
    internal class LTC1679MaxNumberOfKSumPairs
    {
        //Main function to execute the test cases
        public static void Main(string[] args)
        {
            var nums = new int[] { 1, 2, 3, 4 };
            var k = 5;
            var result = new LTC1679MaxNumberOfKSumPairs().MaxOperations(nums, k);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public int MaxOperations(int[] nums, int k)
        {
            var dict = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (!dict.ContainsKey(num))
                {
                    dict[num] = 0;
                }
                dict[num]++;
            }
            var count = 0;
            foreach (var num in nums)
            {
                if (dict[num] == 0)
                {
                    continue;
                }
                dict[num]--;
                if (dict.ContainsKey(k - num) && dict[k - num] > 0)
                {
                    count++;
                    dict[k - num]--;
                }
            }
            return count;
        }
    
    }
}
