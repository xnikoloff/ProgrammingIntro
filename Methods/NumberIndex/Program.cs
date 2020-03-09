using System;

namespace NumberIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            //Method that find a sub element is greter than its two neigbours simultaneously

            int[] arr = { 2, 5, 6, 7, 8, 12, 44 };

            int index = GetNumberIndex(arr);
            Console.WriteLine(index);
        }

        static int GetNumberIndex(int[] arr)
        {
            int index = -1;

            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                {
                    index = i;
                }
            }

            return index;
        }
    }
}
