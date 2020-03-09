using System;

namespace SumEqualsZero
{
    class Program
    {
        static void Main(string[] args)
        {
            //find which of theese numbers have sum of zero
            int a = -5;
            int b = -2;
            int c = 5;
            int d = -2;
            int e = -1;

            if (a + b == 0)
            {
                Console.WriteLine("Nums: {0}, {1}", a, b);
            }

            else if (a + c == 0)
            {
                Console.WriteLine("Nums: {0}, {1}", a, c);
            }

            else if (a + d == 0)
            {
                Console.WriteLine("Nums: {0}, {1}", a, d);
            }

            else if (a + e == 0)
            {
                Console.WriteLine("Nums: {0}, {1}", a, e);
            }

            else if (a + b + c == 0)
            {
                Console.WriteLine("Nums: {0}, {1}, {2}", a, b, c);
            }

            else if (a + b + c + d == 0)
            {
                Console.WriteLine("Nums: {0}, {1}, {2}, {3}", a, b, c, d);
            }

            else if (a + b + c + d + e == 0)
            {
                Console.WriteLine("Nums: {0}, {1}, {2}, {3}, {4}", a, b, c, d, e);
            }
            else if (b + c == 0)
            {
                Console.WriteLine("Nums {0}, {1}", b, c);
            }

            else if (b + c + d == 0)
            {
                Console.WriteLine("Nums {0}, {1}, {2}", b, c, d);
            }

            else if (b + c + d + e == 0)
            {
                Console.WriteLine("Nums {0}, {1}, {2}, {3}", b, c, d, e);
            }

            else if (c + d == 0)
            {
                Console.WriteLine("Nums {0}, {1}", c, d);
            }

            else if (c + d + e == 0)
            {
                Console.WriteLine("Nums {0}, {1}, {2}", c, d, e);
            }

            else if (d + e == 0)
            {
                Console.WriteLine("Nums {0}, {1},", d, e);
            }
        }
    }
}
