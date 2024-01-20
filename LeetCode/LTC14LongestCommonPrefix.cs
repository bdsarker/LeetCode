using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class LTC14LongestCommonPrefix
    {
        public static void Main()
        {
            string[] strs = { "oooflower", "flow", "flight" };
            Console.WriteLine(LongestCommonPrefix(strs));
            Console.ReadLine();
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0) return "";

            string prefix = strs[0];
            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (prefix == "") return "";
                }
            }
            return prefix;
        }
    }
}
