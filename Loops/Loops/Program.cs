using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //all n numbers that are divisible by 3 and 7

            //read n
            Console.Write("n: ");
            byte n = byte.Parse(Console.ReadLine());

            // loop through all n numbers
            for (int i = 1; i <= n; i++)
            {
                //check if the number is disible by 3 and 7
                if (i % 3 != 0 && i % 7 != 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
