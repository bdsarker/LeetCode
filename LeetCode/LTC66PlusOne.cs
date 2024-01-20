using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class LTC66PlusOne
    {
       public static void Main(string[] args)
        {
            int[] arr= { 8,9 };

            foreach (var item in PlusOne(arr))
            {
                Console.Write(item);
            }
        }
        public static int[] MaxDigit(int[] digits)
        {
            int maxVal = Int32.MinValue;
            int index = 0;

            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] > maxVal)
                {
                    maxVal = digits[i];
                    index = i;
                }
            }
            digits[index] = maxVal+1;
            return digits;
        }
        public static int[] PlusOne(int[] digits)
        {
            for (int i = digits.Length-1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i] ++;
                    return digits;
                }
                else
                    digits[i]=0;
            }
            int[] result = new int[digits.Length+1];
            result[0] = 1;
            return result;

        }
        

    }
}
