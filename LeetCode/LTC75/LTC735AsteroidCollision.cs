using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LTC75
{
    internal class LTC735AsteroidCollision
    {
        public int[] AsteroidCollision(int[] asteroids)
        {
            var stack = new Stack<int>();
            foreach (var asteroid in asteroids)
            {
                if (asteroid > 0) // moving right
                {
                    stack.Push(asteroid);
                }
                else // moving left
                {
                    while (stack.Count > 0 && stack.Peek() > 0 && stack.Peek() < -asteroid) // collision
                    {
                        stack.Pop(); // destroy the right moving asteroid
                    }

                    if (stack.Count == 0 || stack.Peek() < 0) // no collision
                    {
                        stack.Push(asteroid); // add the left moving asteroid
                    }
                    else if (stack.Peek() == -asteroid) // collision
                    {
                        stack.Pop(); // destroy both asteroids
                    }
                }
            }
            return stack.Reverse().ToArray();
        }
    }
}
