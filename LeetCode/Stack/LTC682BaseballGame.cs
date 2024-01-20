using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Stack
{
    internal class LTC682BaseballGame
    {
        public int CalPoints(string[] ops)
        {
            Stack<int> stack = new Stack<int>();
            int sum = 0;

            foreach (string op in ops)
            {
                if (op == "+")
                {
                    int top = stack.Pop();
                    int newTop = top + stack.Peek();
                    stack.Push(top);
                    stack.Push(newTop);
                }
                else if (op == "C")
                {
                    stack.Pop();
                }
                else if (op == "D")
                {
                    stack.Push(2 * stack.Peek());
                }
                else
                {
                    stack.Push(int.Parse(op));
                }
            }
            foreach (int score in stack)
            {
                sum += score;
            }
            return sum;
        }
    }
}
