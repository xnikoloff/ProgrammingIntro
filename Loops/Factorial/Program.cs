using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // calculate n!/k!
            static double calculateFactorial(int n)
            {
                int factorial = 1;

                for (int i = 1; i <= n; i++)
                {
                    factorial *= i;
                }

                return factorial;
            }
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("k: ");
            int k = int.Parse(Console.ReadLine());

            double factorialN = calculateFactorial(n);
            double factorialK = calculateFactorial(k);
            double result = factorialN / factorialK;

            Console.WriteLine("{0}! = {1}, {2}! = {3}", n, factorialN, k, factorialK);
            Console.WriteLine("{0}/{1} = {2:f1}", factorialN, factorialK, result);
        }
    }
}
