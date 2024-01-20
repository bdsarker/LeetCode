using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LTC75
{
    internal class LTC334IncreasingTripleSubsequence
    {
        // Main method to run the test cases
        public static void Main(string[] args)
        {
            LTC334IncreasingTripleSubsequence sol = new LTC334IncreasingTripleSubsequence();
            Console.WriteLine(sol.IncreasingTriplet(new int[] { 2, 1, 5, 0, 4, 6 }));
        }
        public bool IncreasingTriplet(int[] nums)
        {
            int min = int.MaxValue;
            int secondMin = int.MaxValue;

            foreach (int num in nums)
            {
                if (num <= min)
                {
                    min = num;
                }
                else if (num <= secondMin)
                {
                    secondMin = num;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
    }
}
