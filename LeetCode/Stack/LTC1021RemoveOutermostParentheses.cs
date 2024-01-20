using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Stack
{
    internal class LTC1021RemoveOutermostParentheses
    {
        // Create a main method here to call and test other methods
        public static void Main(string[] args)
        {
            var s = "((()()))(())";
            //s = "()()";
            Console.WriteLine( new LTC1021RemoveOutermostParentheses().RemoveOuterParentheses(s));
        }
        public string RemoveOuterParentheses(string S)
        {
            var sb = new StringBuilder();
            var stack = new Stack<char>();
    
            foreach (var c in S)
            {
                if (c == '(')
                {
                    if (stack.Count != 0)
                    {
                        sb.Append(c);
                    }
                    stack.Push(c);
                }
                else
                {
                    stack.Pop();
                    if (stack.Count != 0)
                    {
                        sb.Append(c);
                    }
                }
            }
            return sb.ToString();
        }
    
    }
}
