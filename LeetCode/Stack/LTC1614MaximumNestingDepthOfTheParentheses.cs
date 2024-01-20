using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Stack
{
    internal class LTC1614MaximumNestingDepthOfTheParentheses
    {
        // Main Method to test the code with sample inputs
        public static void Main(string[] args)
        {
            string s = "(1+(2*3)+((8)/4))+1";
            Console.WriteLine(new LTC1614MaximumNestingDepthOfTheParentheses().MaxDepth(s));
        }
        public int MaxDepth(string s)
        {
            int maxDepth = 0;
            int currentDepth = 0;
            
            foreach (char c in s)
            {
                if (c == '(')
                {
                    currentDepth++;
                    maxDepth = Math.Max(maxDepth, currentDepth);
                }
                else if (c == ')')
                {
                    currentDepth--;
                }
            }
            return maxDepth;
        }
    }
}
