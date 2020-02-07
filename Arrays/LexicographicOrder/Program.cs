using System;

namespace LexicographicOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fill two arrays with the letters of one word each
            // and check which one is earlier in lexicographic order

            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());

            char[] arr = new char[n];
            char[] arr2 = new char[n];
            int counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("ARR[{0}]: ", i);
                arr[i] = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write("ARR2[{0}]: ", i);
                arr2[i] = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                if (arr[i] < arr2[i])
                {
                    counter++;
                }
            }

            if (counter < n)
            {
                Console.WriteLine("Second array");
            }

            else
            {
                Console.WriteLine("First array");
            }
        }
    }
}
