using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class LTC27RemoveElement
    {
        public static void Main(string[] args)
        {
            int[] arr = { 3, 2, 2, 3 };
            int val = 3;
            Console.WriteLine(RemoveElement(arr,val));
        }
        public static int RemoveElement(int[] nums, int val)
        {
            int index = 0;
            foreach (var item in nums)
            {
                if (item != val)
                    nums[index++] = item;
            }
            return index;
        }
    }
}
