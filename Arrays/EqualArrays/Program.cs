using System;

namespace EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // check if two arrays are equal
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int[] arr2 = new int[n];
            int counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("ARR[{0}]: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write("ARR2[{0}]: ", i);
                arr2[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                if (arr[i] == arr2[i])
                {
                    counter++;
                }
            }

            if (counter == n)
            {
                Console.WriteLine("Arrays are equals");
            }

            else
            {
                Console.WriteLine("Arrays aren't equals");
            }
        }
    }
}
