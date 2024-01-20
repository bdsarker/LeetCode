using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LTC75
{
    internal class LTC345ReverseVowelsOfString
    {

        //main method to execute the code
        public static void Main(string[] args)
        {
            var ltc = new LTC345ReverseVowelsOfString();
            Console.WriteLine(ltc.ReverseVowels("hello"));
            Console.WriteLine(ltc.ReverseVowels("leetcode"));
            Console.WriteLine(ltc.ReverseVowels("aA"));
        }
        public string ReverseVowels(string s)
        {
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
            var chars = s.ToCharArray();
            var left = 0;
            var right = chars.Length - 1;
            while (left < right)
            {
                while (left < right && !vowels.Contains(char.ToLower(chars[left]))) left++;
                while (left < right && !vowels.Contains(char.ToLower(chars[right]))) right--;
                if (left < right)
                {
                    var temp = chars[left];
                    chars[left] = chars[right];
                    chars[right] = temp;
                    left++;
                    right--;
                }
            }
            return new string(chars);
        }
    
    }
}
