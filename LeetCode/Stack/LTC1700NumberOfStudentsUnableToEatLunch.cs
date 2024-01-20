using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Stack
{
    internal class LTC1700NumberOfStudentsUnableToEatLunch
    {
        //Wrie a main method to test the code
        public static void Main(string[] args)
        {
            var students = new int[] { 1, 1, 1, 0, 0, 1 };
            var sandwiches = new int[] { 1, 0, 0, 0, 1, 1 };
            var result = new LTC1700NumberOfStudentsUnableToEatLunch().CountStudents(students, sandwiches);
            Console.WriteLine(result);
        }

        public int CountStudents(int[] students, int[] sandwiches)
        {

            var studentsQueue = new Queue<int>(students);
            var sandwichesQueue = new Queue<int>(sandwiches);

            var count = 0;
            
            while (studentsQueue.Count > 0 && count < studentsQueue.Count)
            {
                if (studentsQueue.Peek() == sandwichesQueue.Peek())
                {
                    studentsQueue.Dequeue();
                    sandwichesQueue.Dequeue();
                    count = 0;
                }
                else
                {
                    var student = studentsQueue.Dequeue();
                    studentsQueue.Enqueue(student);
                    count++;
                }
            }

            return studentsQueue.Count;
        }
    }
}
