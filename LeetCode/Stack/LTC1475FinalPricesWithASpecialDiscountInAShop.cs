using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Stack
{
    internal class LTC1475FinalPricesWithASpecialDiscountInAShop
    {
        // Main Method with test cases 
        public static void Main(string[] args)
        {
            var obj = new LTC1475FinalPricesWithASpecialDiscountInAShop();
            var prices = new int[] { 8, 4, 6, 7, 3 };
            
            var result = obj.FinalPrices(prices);
            
            Console.WriteLine(string.Join(",", result));
        }

        public int[] FinalPrices(int[] prices)
        {
            var stack = new Stack<int>();
            
            for (int i = 0; i < prices.Length; i++)
            {
                while (stack.Count > 0 && prices[stack.Peek()] >= prices[i])
                {
                    prices[stack.Pop()] -= prices[i];
                }
                stack.Push(i);
            }
            
            return prices;
        }
    }
}
