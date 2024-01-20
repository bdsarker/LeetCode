using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LTC75
{
    internal class LTC2352EqualRowAndColumnPairs
    {
        static void Main()
        {
            var solution = new LTC2352EqualRowAndColumnPairs();
            int[][] matrix = {
                new int[] {3, 2 , 1},
                new int[] {1, 7 , 6},
                new int[] {2, 7 , 7}
            };

            int result = solution.EqualPairs(matrix);
            Console.WriteLine("Number of identical pairs: " + result);
        }

        public int EqualPairs(int[][] grid)
        {
            int n = grid.Length;
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (IsEqualRowColumnPair(grid, i, j))
                    {
                        count++;
                    }
                }
            }

            return count;
        }
        private bool IsEqualRowColumnPair(int[][] grid, int row, int col)
        {
            int n = grid.Length;

            for (int k = 0; k < n; k++)
            {
                if (grid[row][k] != grid[k][col])
                {
                    return false;
                }
            }

            return true;
        }

    }
}
