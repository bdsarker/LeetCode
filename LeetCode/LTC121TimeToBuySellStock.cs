using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class LTC121TimeToBuySellStock
    {
        public static void Main(string[] args)
        {
            int[] prices = { 7, 1, 5, 3, 6, 4 };
            Console.WriteLine(MaxProfit(prices));
        }
        public static int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            int minProfit = prices[0];

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minProfit)
                    minProfit= prices[i];
                else if ((prices[i]-minProfit) > maxProfit)
                    maxProfit= prices[i]-minProfit;
            }

            return maxProfit;
        }
    }
}
