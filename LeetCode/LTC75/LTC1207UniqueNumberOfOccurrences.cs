using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LTC75
{
    internal class LTC1207UniqueNumberOfOccurrences
    {
        // Main method to run the test cases
        public static void Main(string[] args)
        {
            var obj = new LTC1207UniqueNumberOfOccurrences();
            Console.WriteLine(obj.UniqueOccurrences(new int[] { -3, 0, 1, -3, 1, 1, 1, -3, 10, 0 }));
        }

        public bool UniqueOccurrences(int[] arr)
        {
            var dict = new Dictionary<int, int>();
            
            foreach (var num in arr)
            {
                if (dict.ContainsKey(num))
                    dict[num]++;
                else
                    dict[num] = 1;
            }

            var set = new HashSet<int>();
            
            foreach (var num in dict.Values)
            {
                if (set.Contains(num))
                    return false;
                set.Add(num);
            }
            return true;
        }
    
    }
}
