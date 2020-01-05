using System;

namespace BiggestOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
            //find and print the biggest number of three
            int a = 6456456;
            int b = 1;
            int c = 0;
            int max = 0;

            if (a > b && b > c)
            {
                max = a;
                Console.WriteLine("max: " + max);
            }

            else if (b > a && a > c)
            {
                max = b;
                Console.WriteLine("max " + b);
            }

            else
            {
                Console.WriteLine("max " + c);
            }
        }
    }
}
