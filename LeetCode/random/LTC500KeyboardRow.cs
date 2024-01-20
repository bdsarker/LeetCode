using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.random
{
    internal class LTC500KeyboardRow
    {
        //main method to execute the code
        internal static void Main(string[] args)
        {
            string[] words = new string[] { "abdfs","cccd","a","qwwewm" };
            Console.WriteLine(string.Join(",", new LTC500KeyboardRow().FindWords(words)));
            Console.ReadLine();
        }

        public string[] FindWords(string[] words)
        {
            
            HashSet<char> str1 = new HashSet<char>() { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p' };
            HashSet<char> str2 = new HashSet<char>() {'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l' };
            HashSet<char> str3 = new HashSet<char>() { 'z', 'x', 'c', 'v', 'b', 'n', 'm' };

            List<string> result = new List<string>();

            foreach (string word in words)
            {
                HashSet<string> str = new HashSet<string>();

                foreach (char c in word.ToLower())
                {
                    if (str1.Contains(c))
                    {
                        str.Add("str1");
                    }
                    else if (str2.Contains(c))
                    {
                        str.Add("str2");
                    }
                    else if (str3.Contains(c))
                    {
                        str.Add("str3");
                    }
                }

                if (str.Count == 1)
                {
                    result.Add(word);
                }
            }
            return result.ToArray();
        }
            
    }
}
