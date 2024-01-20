using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class LTC20ValidParenthesis
    {
        public static void Main(string[] args)
        {
            string str = "(()))[]{}";
            Console.WriteLine(IsValid(str));
        }
        public static bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            Dictionary<char, char> dict = new()
            {
                { '(', ')' },
                { '{', '}' },
                { '[', ']' }
            };

            for (int i = 0; i<s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                    stack.Push(s[i]);
                else if(stack.Count>0 && s[i] == dict[stack.Peek()])
                     stack.Pop();
                else
                    return false;
            }

            return stack.Count==0;
        }
    }
}
