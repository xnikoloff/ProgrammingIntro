using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //sort an array using selection sort

            int[] arr = { 4, 3, 5, 7, 12, 9, 23, 1 };
            int[] arrSorted = new int[arr.Length];
            int smallest = 0;
            int smallestIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                smallest = arr[i];
                smallestIndex = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[smallestIndex])
                    {
                        smallestIndex = j;
                    }
                }

                int temp = arr[smallestIndex];
                arr[smallestIndex] = arr[i];
                arr[i] = temp;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
