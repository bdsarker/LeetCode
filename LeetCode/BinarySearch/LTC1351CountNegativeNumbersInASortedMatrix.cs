using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BinarySearch
{
    internal class LTC1351CountNegativeNumbersInASortedMatrix
    {
        internal static void Main()
        {
            int[][] grid = new int[][]
            {
                new int[] { 4, 3, 2, -1 },
                new int[] { 3, 2, 1, -1 },
                new int[] { 1, 1, -1, -2 },
                new int[] { -1, -1, -2, -3 }
            };
            Console.WriteLine(CountNegatives(grid));
        }

        private static int CountNegatives(int[][] grid)
        {
            int count = 0;
            foreach (int[] row in grid)
            {
                count += row.Count(n => n < 0);
            }
            return count;
        }
    
    }
}
