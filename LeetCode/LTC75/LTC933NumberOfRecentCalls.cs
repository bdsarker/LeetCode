using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LTC75
{
    internal class LTC933NumberOfRecentCalls
    {
        private Queue<int> _queue;

        // Main method to run the test cases
        public static void Main(string[] args)
        {
            Console.WriteLine("LTC933 Number of Recent Calls");
            LTC933NumberOfRecentCalls ltc = new LTC933NumberOfRecentCalls();
            Console.WriteLine(ltc.Ping(1));
            Console.WriteLine(ltc.Ping(100));
            Console.WriteLine(ltc.Ping(3001));
            Console.WriteLine(ltc.Ping(3002));
        }
        public LTC933NumberOfRecentCalls()
        {
            _queue = new Queue<int>();
        }

        public int Ping(int t)
        {
            _queue.Enqueue(t);
            while (_queue.Peek() < t - 3000)
            {
                _queue.Dequeue();
            }
            return _queue.Count;
        }
    }
}
