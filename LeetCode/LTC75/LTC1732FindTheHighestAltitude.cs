using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LTC75
{
    internal class LTC1732FindTheHighestAltitude
    {
        //Main function to execute the test cases
        public static void Main(string[] args)
        {
            int[] gain = { -5, 1, 5, 0, -7 };
            Console.WriteLine(new LTC1732FindTheHighestAltitude().LargestAltitude(gain));
        }

        public int LargestAltitude(int[] gain)
        {
            int max = 0;
            int current = 0;
            foreach (int g in gain)
            {
                current += g;
                if (current > max)
                {
                    max = current;
                }
            }
            return max;
        }
    }
}
