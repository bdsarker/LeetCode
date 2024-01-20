using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LTC75
{
    internal class LTC394DecodedString
    {
        //Main method to execute the code
        public static void Main(string[] args)
        {
            var obj = new LTC394DecodedString();
            var s = "3[a2[c]]";
            var result = obj.DecodeString(s);
            Console.WriteLine(result);
            //Console.ReadLine();
        }
        public string DecodeString(string s)
        {
            var stack = new Stack<string>();
            var num = 0;
            var result = "";
            
            foreach (var c in s)
            {
                if (c >= '0' && c <= '9')
                {
                    num = num * 10 + c - '0';
                }
                else if (c == '[')
                {
                    stack.Push(result);
                    stack.Push(num.ToString());
                    result = "";
                    num = 0;
                }
                else if (c == ']')
                {
                    var n = int.Parse(stack.Pop());
                    var temp = stack.Pop();
                    for (var i = 0; i < n; ++i)
                    {
                        temp += result;
                    }
                    result = temp;
                }
                else
                {
                    result += c;
                }
            }
            return result;
        }
    }
}
