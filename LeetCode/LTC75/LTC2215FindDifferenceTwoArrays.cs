using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LTC75
{
    internal class LTC2215FindDifferenceTwoArrays
    {
        //Main Method with test cases
        public static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3 };
            int[] nums2 = { 2, 4, 6 };

            LTC2215FindDifferenceTwoArrays obj = new LTC2215FindDifferenceTwoArrays();
            IList<IList<int>> result = obj.FindDifference(nums1, nums2);

            foreach (var item in result)
            {
                foreach (var item1 in item)
                {
                    Console.Write(item1 + " ");
                }
                Console.WriteLine();
            }
        }
        public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            HashSet<int> set1 = new HashSet<int>(nums1);
            HashSet<int> set2 = new HashSet<int>(nums2);

            set1.ExceptWith(nums2);
            set2.ExceptWith(nums1);

            return new List<IList<int>> { set1.ToList(), set2.ToList() };


        }

    }
}
