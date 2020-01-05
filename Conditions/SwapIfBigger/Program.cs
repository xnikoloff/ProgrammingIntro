using System;

namespace SwapIfBigger
{
    class Program
    {
        static void Main(string[] args)
        {
            //check which number is bigger and swap them if the first is bigger
            int a = 12;
            int b = 5;
            int bHelper = b;

            Console.WriteLine("a: {0} b: {1}", a, b);

            if (a > b)
            {
                b = a;
                a = bHelper;
            }

            Console.WriteLine("a: {0} b: {1}", a, b);
        }
    }
}
