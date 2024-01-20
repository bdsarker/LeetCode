using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HeapQueue
{
    internal class LTC1046LastStoneWeight
    {
        public static void Main(string[] args)
        {
            int[] stones = { 2, 7, 4, 1, 8, 1 };
            Console.WriteLine(new LTC1046LastStoneWeight().LastStoneWeight(stones));
        }

        public int LastStoneWeight(int[] stones)
        {
            List<int> ls = stones.ToList();
            while (ls.Count > 1)
            {
                ls = ls.OrderByDescending(s => s).ToList();
                int a = ls[0];
                int b = ls[1];
                if (a == b)
                {
                    ls.RemoveAt(1);
                    ls.RemoveAt(0);
                }
                else
                {
                    ls[1] = a - b;
                    ls.RemoveAt(0);
                }
            }
            return ls.Count > 0 ? ls.First() : 0;
        }
    }
}
