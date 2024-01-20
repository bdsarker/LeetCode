using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LTC75
{
    internal class LTC11ContainerWithMostWater
    {
        //Main method to execute the code
        public static void Main(string[] args)
        {
            int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            LTC11ContainerWithMostWater ltc = new LTC11ContainerWithMostWater();
            Console.WriteLine(ltc.MaxArea(height));
        }

        public int MaxArea(int[] height)
        {
            int maxArea = 0;
            int left = 0;
            int right = height.Length - 1;

            while (left < right)
            {
                int area = Math.Min(height[left], height[right]) * (right - left);

                if (area > maxArea)
                {
                    maxArea = area;
                }

                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return maxArea;
        }
    
    }
}
