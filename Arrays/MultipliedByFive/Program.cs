using System;

namespace MultipliedByFive
{
    class Program
    {
        static void Main(string[] args)
        {
            // multiply all elements of an array by 5
            // and output them

            int[] arr = new int[20];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += i * 5;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " "); 
            }
        }
    }
}
