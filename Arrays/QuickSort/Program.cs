using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //sort an array using quick sort

            void quickSort(int[] arr, int left, int right)
            {
                int i = left, j = right;

                //set a pivot number
                int pivot = arr[(left + right) / 2];

                //check if the the left is less than or equat to the right
                while (i <= j)
                {
                    while (arr[i] < pivot)
                        i++;

                    while (arr[j] > pivot)
                        j--;

                    //swap elements if left is less than of equal to right
                    if (i <= j)
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;

                        i++;
                        j--;
                    }

                    //sort the array
                    if (left < j)
                        quickSort(arr, left, j);

                    if (i < right)
                        quickSort(arr, i, right);
                }
            }

            void SortArray(int[] arr)
            {
                quickSort(arr, 0, arr.Length - 1);
            }


            int[] arr = { 4, 2, 7, 3, 9, 8, 6, 1, 5 };
            Console.WriteLine("Array before sort : ");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Array after sort: ");

            SortArray(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
