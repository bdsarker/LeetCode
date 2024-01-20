using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Matrix
{
    internal class LTC1337TheKWeakestRowsInAMatrix
    {
        // Main method to run the test cases

        public static void Main()
        {
            var mat = new int[][]
            {
                new int[]{1,1,0,0,0},
                new int[]{1,1,1,1,0},
                new int[]{1,0,0,0,0},
                new int[]{1,1,0,0,0},
                new int[]{1,1,1,1,1}
            };
            var k = 3;
            var result = new LTC1337TheKWeakestRowsInAMatrix().KWeakestRows(mat, k);
            Console.WriteLine($"The weakest rows are: {string.Join(',', result)}");
        }

        public int[] KWeakestRows(int[][] mat, int k)
        {
            var rowStrength = new Dictionary<int, int>();
            
            for (int i = 0; i < mat.Length; i++)
            {
                rowStrength.Add(i, mat[i].Sum());
            }

            var sorted = rowStrength.OrderBy(x => x.Value).ThenBy(x => x.Key).Take(k);
            
            

            return sorted.Select(x => x.Key).ToArray();
        }
    
    }
}
