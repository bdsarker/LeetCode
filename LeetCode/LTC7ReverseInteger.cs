using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class LTC7ReverseInteger
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Reverse(21474836)); //2147483647
        }

        public static int Reverse(int x)
        {
            int res = 0;
            while (x != 0) {
                int num = x % 10;
                int tmp = res*10+num;
                if ((tmp - num)/10 != res)
                    return 0;
                res = tmp;
                x=x/10;
            }
            return res;
        }
    }
}
