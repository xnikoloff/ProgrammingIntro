using System;

namespace Factorial2
{
    class Program
    {
        static void Main(string[] args)
        {
            //calculate N!*K!/(N-K)! (1 < N < K)
            Console.WriteLine("Find N!*K!/(N-K)! (1 < N < K)");
            int n = 1, k = 1;


            // make sure 1 < n < k
            while (true)
            {
                Console.Write("n: ");
                n = int.Parse(Console.ReadLine());


                Console.Write("k: ");
                k = int.Parse(Console.ReadLine());

                if ((n < 1 && k < 1) || (n < k))
                {
                    Console.WriteLine("1 < K < N");
                }

                else
                {
                    break;
                }

            }

            Console.WriteLine("N={0}, K={1}", n, k);

            int factN = 1, factK = 1;

            // calculate factorial of n
            for (int i = 1; i <= n; i++)
            {
                factN *= i;
            }

            //calculate factorial of k
            for (int i = 1; i <= k; i++)
            {
                factK *= i;
            }

            //print result 
            Console.WriteLine("N!={0}, K!={1}", factN, factK);


            // make the rest of the calculation

            int nkSubstact = n - k;
            Console.WriteLine("{0}-{1}={2}", n, k, nkSubstact);
            int nSubstractTemp = 1;

            for (int i = 1; i <= nkSubstact; i++)
            {
                nSubstractTemp *= i;
            }

            Console.WriteLine("{0}!={1}", nkSubstact, nSubstractTemp);

            int nKMultiplied = factN * factK;
            Console.WriteLine("{0}*{1}={2}", factN, factK, nKMultiplied);

            int result = nKMultiplied / nSubstractTemp;
            Console.WriteLine("{0}/{1}={2}", nKMultiplied, nSubstractTemp, result);

            //print the final result
            Console.WriteLine(result);
        }
    }
}
