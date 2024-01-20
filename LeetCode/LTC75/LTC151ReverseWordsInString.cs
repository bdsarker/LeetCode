using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LTC75
{
    internal class LTC151ReverseWordsInString
    {
        //Main method to execute the code
        public static void Main(string[] args)
        {
            var obj = new LTC151ReverseWordsInString();
            var s = "the sky is blue";
            Console.WriteLine(obj.ReverseWords(s));
            Console.ReadLine();
        }

        public string ReverseWords(string s)
        {
            if (s == null) return null;
            var words = s.Split(' ');
            var sb = new StringBuilder();

            for (int i = words.Length - 1; i >= 0; i--)
            {
                if (words[i].Length > 0)
                {
                    sb.Append(words[i]);
                    sb.Append(' ');
                }
            }
            if (sb.Length > 0) sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }
    }
}
