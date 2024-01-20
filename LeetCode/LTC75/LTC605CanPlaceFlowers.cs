using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LTC75
{
    internal class LTC605CanPlaceFlowers
    {
        public static void Main()
        {
            int[] flowerbed = { 0, 0, 0, 0, 1 };
            int n = 2;
            Console.WriteLine(new LTC605CanPlaceFlowers().CanPlaceFlowers(flowerbed, n));
        }

        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int count = 0;
            for (int i = 0; i < flowerbed.Length; i++)
            {
                //Console.WriteLine("i = " + i + " count = " + flowerbed[i-1]);
                if (flowerbed[i] == 0 && 
                    (i == 0 || flowerbed[i - 1] == 0) &&
                    (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0))
                {
                    flowerbed[i] = 1;
                    count++;
                }
            }
            return count >= n;
        }
    }
}
