using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LTC75
{
    internal class LTC1456MaximumNumberOfVoule
    {
        //Main Method with test cases
        public static void Main(string[] args)
        {
            LTC1456MaximumNumberOfVoule ltc = new LTC1456MaximumNumberOfVoule();
            Console.WriteLine(ltc.MaxVowels("abciiidef", 3));
        }
        internal int MaxVowels(string s, int k)
        {
            int max = 0;
            int count = 0;
            int i = 0;

            for (; i < k; i++)
            {
                if (IsVowel(s[i]))
                {
                    count++;
                }
            }

            max = count;
            for (; i < s.Length; i++)
            {
                if (IsVowel(s[i]))
                {
                    count++;
                }

                if (IsVowel(s[i - k]))
                {
                    count--;
                }

                max = Math.Max(max, count);
            }
            return max;
        }

        private bool IsVowel(char c)
        {
            return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
        }
    
    }
}
