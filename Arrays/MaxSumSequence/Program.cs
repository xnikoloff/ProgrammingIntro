using System;

namespace MaxSumSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            // find the biggest sum formed by a sequence 
            // of numbers in an array

            int[] arr = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

            int maxSoFar = arr[0];
            int maxEndingHere = arr[0];


            for (int i = 1; i < arr.Length; i++)
            {
                maxEndingHere = Math.Max(maxEndingHere + arr[i], arr[i]);
                maxSoFar = Math.Max(maxSoFar, maxEndingHere);
            }

            Console.WriteLine(maxSoFar);
        }
    }
}
