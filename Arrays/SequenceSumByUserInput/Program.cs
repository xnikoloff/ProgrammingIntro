using System;

namespace SequenceSumByUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            // Wait for the user to input a number and check
            //if there is sequence of numbers in an array
            // which sum is equal to the input

            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

            int result = 0;

            for (int left = 0; left < arr.Length; left++)
            {
                for (int right = left; right < arr.Length; right++)
                {
                    int windowsSum = 0;

                    for (int k = left; k < right; k++)
                    {
                        windowsSum += arr[k];
                    }

                    if (n == windowsSum)
                    {
                        result = windowsSum;
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
