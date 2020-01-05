using System;

namespace OperatorsAndExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //odd or even using ternary opearator
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());

            string oddOrEven = (n % 2 == 0) ? n + " is even" : n + " is odd";
            Console.WriteLine(oddOrEven);
        }
    }
}
