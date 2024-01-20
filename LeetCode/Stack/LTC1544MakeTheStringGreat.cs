using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Stack
{
    internal class LTC1544MakeTheStringGreat
    {
        // Main function to run the test cases
        public static void Main()
        {
            var s = "leEeetcode";
            var obj = new LTC1544MakeTheStringGreat();
            var result = obj.MakeGood(s);
            Console.WriteLine(result);
        }
        public string MakeGood(string s)
        {
            var stack = new Stack<char>();
            foreach (var c in s)
            {
                if (stack.Count > 0 && Math.Abs(stack.Peek() - c) == 32)
                    stack.Pop();
                else
                    stack.Push(c);
            }

            var sb = new StringBuilder();
            
            while (stack.Count > 0)
                sb.Append(stack.Pop());
            
            return new string(sb.ToString().Reverse().ToArray());
        }
    }
}
