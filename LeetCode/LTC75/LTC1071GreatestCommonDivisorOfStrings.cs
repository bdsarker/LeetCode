using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LTC75
{
    internal class LTC1071GreatestCommonDivisorOfStrings
    {

        public static void Main(string[] args)
        {
            string str1 = "ABCABC";
            string str2 = "ABC";
            Console.WriteLine(new LTC1071GreatestCommonDivisorOfStrings().GcdOfStrings(str1, str2));


        }

        public int gcd(int a, int b)
        {
            if (a == 0) return b;
            return gcd(b % a, a);
        }
        //solve this problem by using Euclidean algorithm gcd(a,b) = gcd(b,a%b)
        public string GcdOfStrings(string str1, string str2)
        {

            int len1 = str1.Length;
            int len2 = str2.Length;

            if ((str1 + str2).Equals(str2 + str1))
            {
                int index = gcd(len1, len2);
                return str1.Substring(0, index);
            }
            else
            {
                return "";
            }

        }

    }
}
