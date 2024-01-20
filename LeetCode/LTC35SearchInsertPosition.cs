using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class LTC35SearchInsertPosition
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 3, 5, 6 };
            int target = -7;
            Console.WriteLine(~target);
            Console.WriteLine(SearchInsert(arr, target));
        }
        public static int SearchInsert(int[] nums, int target)
        {
            int index=Array.BinarySearch(nums, target);
            if (index > 0) 
                return index;
            else return ~index;
        }
    }
}
