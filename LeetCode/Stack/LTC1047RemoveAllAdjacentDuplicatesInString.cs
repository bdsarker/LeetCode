using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Stack
{
    internal class LTC1047RemoveAllAdjacentDuplicatesInString
    {
        // Write a main method to test your code
        public static void Main(string[] args)
        {
            string s = "azxxzy";
            Console.WriteLine(new LTC1047RemoveAllAdjacentDuplicatesInString().RemoveDuplicates(s));
        }

        public string RemoveDuplicates(string S)
        {

            Stack<char> stack = new Stack<char>();
    
            foreach (char c in S)
            {
                if (stack.Count == 0 || stack.Peek() != c)
                    stack.Push(c);
                
                else
                    stack.Pop();
                
            }
            // Revarse the stack
            char[] arr = stack.ToArray();
            Array.Reverse(arr);

            StringBuilder sb = new StringBuilder();
            
            foreach (char c in arr)
                sb.Append(c);

            return sb.ToString();
        }
    
    }
}
