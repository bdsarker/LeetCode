using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.random
{
    internal class LTC599MinimumIndexSumOfTwoLists
    {
        // main method with data
        internal static void Main(string[] args)
        {
            var list1 = new string[] { "Shogun", "Piatti", "Burger", "KFC" };
            var list2 = new string[] { "Piatti", "Shogun", "Hungry", "Shogun" };
            var res = new LTC599MinimumIndexSumOfTwoLists().FindRestaurant(list1, list2);
            Console.WriteLine(string.Join(",", res));
            Console.ReadLine();
        }
        public string[] FindRestaurant(string[] list1, string[] list2)
        {
            var map = new Dictionary<string, int>();
            for (int i = 0; i < list1.Length; i++)
            {
                map.Add(list1[i], i);
            }

            var min = int.MaxValue;
            
            var res = new List<string>();
            
            for (int i = 0; i < list2.Length; i++)
            {
                if (map.ContainsKey(list2[i]))
                {
                    var sum = i + map[list2[i]];
                    if (sum < min)
                    {
                        min = sum;
                        res.Clear();
                        res.Add(list2[i]);
                    }
                    else if (sum == min)
                    {
                        res.Add(list2[i]);
                    }
                }
            }
            return res.ToArray();
        }
    }
}
