using System;

namespace MostCommonElement
{
    class Program
    {
        static void Main(string[] args)
        {
            //find the most common element in an array

            string[] arr = { "red", "blue", "green", "red", "red", "blue", "green", "red" };
            int[] arrInt = { 2, 5, 2, 13, 5, 8, 2, 4, 2 };
            string element = "";
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                string tempElement = arr[i];
                int tempCount = 0;

                for (int j = 0; j < arr.Length; j++)
                {
                    if (tempElement == arr[j])
                    {
                        tempCount++;
                    }
                }

                if (tempCount > count)
                {
                    element = tempElement;
                    count = tempCount;
                }
            }

            Console.WriteLine("Element: " + element + " Count: " + count);
        }
    }
}
