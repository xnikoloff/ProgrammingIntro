using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            // sum of fibbonaci nums


            Console.Write("Count: ");
            int count = int.Parse(Console.ReadLine());

            int num1 = 0;
            int num2 = 1;
            
            if (count <= 1)
            {
                Console.WriteLine(1);
            }

            else
            {
                for (int i = 0; i < count; i++)
                {
                    Console.Write(num1 + " ");
                    int sumOfPrevTwo = num1 + num2;
                    num1 = num2;
                    num2 = sumOfPrevTwo;

                }
            }

        }
    }
}
