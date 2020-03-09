using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use binary search 
            static int binarySearch(int[] arr, int l, int r, int x)
            {
                if (r >= l)
                {
                    int mid = (l + r) / 2;

                    if (arr[mid] == x)
                    {
                        return mid;
                    }

                    else if (arr[mid] > x)
                    {
                        return binarySearch(arr, l, mid - 1, x);
                    }

                    else
                    {
                        return binarySearch(arr, mid + 1, r, x);
                    }
                }

                else
                {
                    return -1;
                }
            }

            int[] arr = { 18, 25, 39, 67, 72, 91, 102, 113, 225, 247, 306 };
            int bS = binarySearch(arr, 0, arr.Length, 67);
            Console.WriteLine(bS);
        }
    }
}
