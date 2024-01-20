using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Stack
{
    internal class LTC316RemoveDuplicateLetters
    {
        // Main function to run the test cases
        public static void Main()
        {
            var input = "cbacdcbc";
            var obj = new LTC316RemoveDuplicateLetters();
            var result = obj.RemoveDuplicateLetters(input);
            Console.WriteLine(result);
        }
        public string RemoveDuplicateLetters(string s)
        {
            var stack = new Stack<char>();
            var set = new HashSet<char>();
            var lastOccurence = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
                lastOccurence[s[i]] = i;

            for (int i = 0; i < s.Length; i++)
            {
                var c = s[i];
                if (set.Contains(c))
                    continue;

                while (stack.Count > 0 && c < stack.Peek() && lastOccurence[stack.Peek()] > i)
                    set.Remove(stack.Pop());

                stack.Push(c);
                set.Add(c);
            }

            var sb = new StringBuilder();
            while (stack.Count > 0)
                sb.Insert(0, stack.Pop());

            return sb.ToString();
        }
    
    }
}
