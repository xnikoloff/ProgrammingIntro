using System;

namespace GreatestElementOfSubarray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Find greatest element of subarray. Use Selection Sort

            //Find the greatest number in the whole array
            int[] arr = { 2, 4, 1, 3, 28, 7, 15, 23 };
            Sort(arr);
            PrintArray(arr);
            int maxNumber = FindMaxNumber(arr);
            Console.WriteLine(maxNumber);

            //Find max number in subarrat
            int maxReg = FindMaxInRegion(arr, 0, 5);
            Console.WriteLine(maxReg);
        }

        static void Sort(int[] arr)
        {
            int minIndex = 0;
            int temp = 0;

            if (arr.Length <= 1)
            {
                return;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                minIndex = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }

        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("ARR[{0}]: ", i);
                Console.WriteLine(arr[i]);
            }
        }

        static int FindMaxNumber(int[] arr)
        {
            int max = arr[arr.Length - 1];

            return max;
        }

        static int FindMaxInRegion(int[] arr, int start, int length)
        {
            int max = 0;
            int bestMax = 0;

            for (int i = start + 1; i <= length; i++)
            {
                for (int j = i; j <= length; j++)
                {
                    if (arr[i - 1] < arr[i])
                    {
                        max = arr[i];
                    }
                }

                if (bestMax < max)
                {
                    bestMax = max;
                }
            }

            return bestMax;
        }
    }
}
