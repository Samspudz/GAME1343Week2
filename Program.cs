/*
 * author: Adam Marshall
 * date: 01/31/2023
 * class: GAME 1343
 * project: Week 2 Assignment
 */

namespace Week2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myVar = 11;

            Console.WriteLine(-1 + 4 * myVar);
            Console.WriteLine((35 + 5) % myVar);
            Console.WriteLine(14 + -4 * 6 / 12);
            Console.WriteLine(2 + 12 / 6 * 1 - myVar % 2);

            if(myVar * myVar < 100)
            {
                Console.WriteLine("myVar is less than 10");
            }
            else 
            {
                Console.WriteLine("myVar is greater than 10");
            }

        }
    }
}