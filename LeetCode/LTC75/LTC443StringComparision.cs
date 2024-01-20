using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LTC75
{
    internal class LTC443StringCompression
    {

        //implement the main method here to run the test case
        public static void Main(string[] args)
        {
            char[] chars = new char[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' };
            Console.WriteLine(new LTC443StringCompression().Compress(chars));
            Console.ReadLine();
        }

        public int Compress(char[] chars)
        {
            int i = 0;
            int j = 0;
            while (i < chars.Length)
            {
                int count = 0;
                char c = chars[i];
                while (i < chars.Length && chars[i] == c)
                {
                    i++;
                    count++;
                }
                //chars[j++] = c;
                j++;
                if (count > 1)
                {
                    foreach (char digit in count.ToString())
                    {
                        //chars[j++] = digit;
                        j++;
                    }
                }
            }
            return j;
        }
        
    
    }
}
