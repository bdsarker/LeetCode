using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LTC75
{
    internal class LTC2390RemovingStarsFromAString
    {
        // Main function with sample test cases
        public static void Main(string[] args)
        {
            Console.WriteLine(RemoveString2("leet**cod*e"));

        }
        internal static string RemoveStars(string s)
        {

            if (s == null || s.Length == 0)
            {
                return s;
            }
            char[] chars = s.ToCharArray();
            int slow = 0;
            int fast = 0;
            while (fast < chars.Length)
            {
                if (chars[fast] != '*')
                {
                    chars[slow++] = chars[fast++];
                }
                else
                {
                    fast++;
                }
            }
            return new string(chars, 0, slow);
        }

        internal static string RemoveString2(string s)
        {
            var chars = new Stack<char>();
            
            foreach (var c in s)
            {
                if (c == '*' && chars.Count()!=0)
                {
                    chars.Pop();
                }
                else
                {
                    chars.Push(c);
                }
            }
            
            var revStack = new Stack<char>();
            
            // reverse the stack and append to string builder
            while (chars.Count() != 0)
            {
                revStack.Push(chars.Pop());
            }

            var sb = new StringBuilder();
            while (revStack.Count() != 0)
            {
                sb.Append(revStack.Pop());
            }

            return sb.ToString();
            
        }
    
    }
}
