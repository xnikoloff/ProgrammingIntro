using System;

namespace LongestSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            // find the longest sequence of same numbers in an array

            int[] arr = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };

            int start = 0;
            int lenght = 1;
            int bestStart = 0;
            int bestLenght = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] != arr[i - 1])
                {
                    start = i;
                    lenght = 1;
                }

                else
                {
                    lenght++;
                }



                if (bestLenght < lenght)
                {
                    bestStart = start;
                    bestLenght = lenght;
                }



            }

            for (int i = 0; i <= bestLenght - 1; i++)
            {
                Console.Write(arr[bestStart] + " ");
                bestStart++;
            }
        }
    }
}
