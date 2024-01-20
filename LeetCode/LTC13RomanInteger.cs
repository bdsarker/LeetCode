using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class LTC13RomanInteger
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(RomanToInt("III"));
            Console.WriteLine(RomanToInt("IV"));
            Console.WriteLine(RomanToInt("IX"));
            Console.WriteLine(RomanToInt("LVIII"));
            Console.WriteLine(RomanToInt("MCMXCIV"));
        }
        public static int RomanToInt(string s)
        {


            Dictionary<char, int> roman = new Dictionary<char, int>();
            roman.Add('I', 1);
            roman.Add('V', 5);
            roman.Add('X', 10);
            roman.Add('L', 50);
            roman.Add('C', 100);
            roman.Add('D', 500);
            roman.Add('M', 1000);

            char[] charArray = s.ToCharArray();
            int result = 0;
            int current = 0;
            int next = 0;

            for (int i = 0; i < charArray.Length; i++)
            {
                current = roman[charArray[i]];

                if (i + 1 < charArray.Length)
                {
                    next = roman[charArray[i + 1]];
                }
                else
                {
                    next = 0;
                }

                if (current < next)
                {
                    result += next - current;
                    i++;
                }
                else
                {
                    result += current;
                }
            }

            return result;
        }
    }
}
