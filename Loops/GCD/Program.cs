using System;

namespace GCD
{
    class Program
    {
        static void Main(string[] args)
        {
            // find the Greatest Common Divisor of two numbers
            int x = 24;
            int y = 36;

            int gcd = 0;

            if (x % y == 0)
            {
                gcd = y;
            }

            else
            {
                gcd = 1;
            }

            for (int i = 1; i <= x; i++)
            {
                if (x % i == 0 && y % i == 0)
                {
                    gcd = i;
                }
            }
            
            Console.WriteLine("GCD of {0} and {1} is {2}", x, y, gcd);
        }
    }
}
