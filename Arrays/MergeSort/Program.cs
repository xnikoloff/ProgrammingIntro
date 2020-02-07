using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            // sort an array using merge sort
            static int[] mergeSort(int[] arr)
            {
                int[] left;
                int[] right;
                int[] result = new int[arr.Length];

                //check if length is less than 1 so that 
                //the recursion can be stoped
                if (arr.Length <= 1)
                {
                    return arr;
                }

                int midPoint = arr.Length / 2; //find the mid point of the array

                // the left part of the array
                // will have length from 0 to the mid point
                left = new int[midPoint];

                //if the array has even length 
                //the right part of the array will have 
                //length from 0 to the midpoint, too
                if (arr.Length % 2 == 0)
                {
                    right = new int[midPoint];
                }

                //else it will have the length of
                //the left part + 1
                else
                {
                    right = new int[midPoint + 1];
                }

                //fill the left array
                for (int i = 0; i < midPoint; i++)
                {
                    left[i] = arr[i];
                }

                //fill the right part
                int x = 0;

                for (int i = midPoint; i < arr.Length; i++)
                {
                    right[x] = arr[i];
                    x++;
                }


                left = mergeSort(left);
                right = mergeSort(right);
                result = merge(left, right);

                return result;
            }

            static int[] merge(int[] left, int[] right)
            {
                int resultLenght = left.Length + right.Length;
                int[] result = new int[resultLenght];

                int indexLeft = 0, indexRight = 0, indexResult = 0;

                while (indexLeft < left.Length || indexRight < right.Length)
                {
                    if (indexLeft < left.Length && indexRight < right.Length)
                    {
                        if (left[indexLeft] <= right[indexRight])
                        {
                            result[indexResult] = left[indexLeft];
                            indexLeft++;
                            indexResult++;
                        }

                        else
                        {
                            result[indexResult] = right[indexRight];
                            indexRight++;
                            indexResult++;
                        }
                    }

                    else if (indexLeft < left.Length)
                    {
                        result[indexResult] = left[indexLeft];
                        indexResult++;
                        indexLeft++;
                    }

                    else if (indexRight < right.Length)
                    {
                        result[indexResult] = right[indexRight];
                        indexResult++;
                        indexRight++;
                    }
                }

                return result;
            }

            int[] arrToSort = { 4, 2, 7, 12, 6, 44, 18 };
            int[] arrSorted = mergeSort(arrToSort);

            for (int i = 0; i < arrSorted.Length; i++)
            {
                Console.WriteLine(arrSorted[i]);
            }
        }
    }
}
