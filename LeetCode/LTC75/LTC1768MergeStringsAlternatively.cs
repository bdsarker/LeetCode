using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LTC75
{
    internal class LTC1768MergeStringsAlternatively
    {
        public static void Main()
        {
            string word1 = "abc";
            string word2 = "pqr";
            Console.WriteLine(new LTC1768MergeStringsAlternatively().MergeAlternately(word1, word2));
        }

        public string MergeAlternately(string word1, string word2)
        {
            StringBuilder sb = new StringBuilder();
            int i = 0;
            while (i < word1.Length && i < word2.Length)
            {
                sb.Append(word1[i]);
                sb.Append(word2[i]);
                i++;
            }

            if (i < word1.Length)
            {
                sb.Append(word1.Substring(i));
            }
            else if (i < word2.Length)
            {
                sb.Append(word2.Substring(i));
            }
            return sb.ToString();
        }
    }
}
