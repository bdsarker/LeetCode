using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Stack
{
    internal class LTC2696MinimumStringLengthAfterRemovingSubstrings
    {
        // main function to test the code with different test cases
        public static void Main(string[] args)
        {
            //Console.WriteLine(MinimumLength("ABABABAB"));
           // Console.WriteLine(MinimumLength("AABBCC"));
            Console.WriteLine(MinimumLength("AAAAA"));
            //Console.WriteLine(MinimumLength("BBBBB"));
        }

        /*
            You are given a string s consisting only of uppercase English letters.
            You can apply some operations to this string where, in one operation, you can remove any occurrence of one of the substrings "AB" or "CD" from s.
            Return the minimum possible length of the resulting string that you can obtain.
         */
        internal static int MinimumLength(string s) 
        { 
          
            var stack = new Stack<char>();

            foreach(char c in s)
            {
                if (stack.Count > 0 && stack.Peek() == 'A' && c == 'B')
                    stack.Pop();
                else if (stack.Count > 0 && stack.Peek() == 'C' && c == 'D')
                    stack.Pop();
                else
                    stack.Push(c);
            }
            return stack.Count;
        }
    }
}
