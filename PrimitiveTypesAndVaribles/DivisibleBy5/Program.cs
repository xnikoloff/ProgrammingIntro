using System;

namespace DivisibleBy5
{
    class Program
    {
        static void Main(string[] args)
        {
            //read two numbers and find how many numbers are there between them that are divisible by 5
            int counter = 0;

            Console.Write("X: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Y: ");
            int y = int.Parse(Console.ReadLine());

            int abs = Math.Abs(x - y);
            int absHelper = abs;

            for (int i = 0; i < abs; i++)
            {
                absHelper++;
                if (absHelper % 5 == 0)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
