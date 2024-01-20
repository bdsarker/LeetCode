using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LTC75
{
    internal class LTC1431KidsWithGreatestNumberOfCandies
    {
        public static void Main(string[] args)
        {
            int[] candies = { 2, 3, 5, 1, 3 };
            int extraCandies = 3;
            var list= new LTC1431KidsWithGreatestNumberOfCandies().KidsWithCandies(candies, extraCandies);

            // print all the elements in the var
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            int max = candies.Max();
            IList<bool> result = new List<bool>();

            foreach (int candy in candies)
            {
                result.Add(candy + extraCandies >= max);
            }
            return result;
        }
    }
}
