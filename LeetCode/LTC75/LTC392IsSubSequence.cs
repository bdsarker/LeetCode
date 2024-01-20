using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LTC75
{
    internal class LTC392IsSubSequence
    {
        //implement the main method here to run the test case
        public static void Main(string[] args)
        {
            string s = "abc";
            string t = "ahbgdc";
            Console.WriteLine(new LTC392IsSubSequence().IsSubsequence(s, t));
            Console.ReadLine();
        }

        public bool IsSubsequence(string s, string t)
        {
            int sIndex = 0;
            int tIndex = 0;

            while (sIndex < s.Length && tIndex < t.Length)
            {
                if (s[sIndex] == t[tIndex])
                {
                    sIndex++;
                    tIndex++;
                }
                else
                    tIndex++;
            }

            return sIndex == s.Length;
        }
    
    }
}
