using System;

namespace LongestUprisingSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            // find the longest uprising sequence of numbers in an array
            int[] arr = { 3, 2, 3, 4, 2, 2, 4 };

            int start = 0;
            int length = 1;
            int bestStart = 0;
            int bestLength = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (!(arr[i] > arr[i - 1]))
                {
                    start = i;
                    length = 1;
                }

                else
                {
                    length++;
                }

                if (bestLength < length)
                {
                    bestStart = start;
                    bestLength = length;
                }
            }

            for (int i = 0; i < bestLength; i++)
            {
                Console.WriteLine(arr[bestStart]);
                bestStart++;
            }
        }
    }
}
