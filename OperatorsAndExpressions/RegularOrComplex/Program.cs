using System;

namespace RegularOrComplex
{
    class Program
    {
        static void Main(string[] args)
        {
            //check if number is regular or complex
            Console.Write("n: ");
            int input = int.Parse(Console.ReadLine());
            int matchCounter = 0;

            if (input > 1 && input < 100)
            {
                for (int i = 1; i <= input; i++)
                {
                    if (input % i == 0)
                    {
                        matchCounter++;
                    }
                }

                if (matchCounter > 2)
                {
                    Console.WriteLine("Complex");
                }

                else
                {
                    Console.WriteLine("Regular");
                }
            }
        }
    }
}
