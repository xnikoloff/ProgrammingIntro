using System;

namespace SubElement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Method that checks if a sub element is greater or smaller than its neighbours 
            //and returns true or false respectively

            //input a number to be searched into the array
            Console.Write("x: ");
            int x = int.Parse(Console.ReadLine());

            //initialize an array of integers
            int[] arr = { 2, 3, 5, 8, 1, 6, 12, 23 };

            //get the index of the searhed element and if this element is the first of the last
            //print that it cannot be checked because it has no neighbours
            int index = GetIndex(arr, x);
            if ((GetIndex(arr, x) - 1) < 0 || (GetIndex(arr, x) + 1) > arr.Length - 1)
            {
                Console.WriteLine("This number cannot be checked!");
                return;
            }

            //if the condition above is true, check if the number is bigger than its neighbours
            if (CheckIfIsBigger(arr, index))
            {
                Console.WriteLine("true");
            }

            else
            {
                Console.WriteLine("false");
            }
        }

        static int GetIndex(int[] arr, int x)
        {
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (x == arr[i])
                {
                    index = i;
                }
            }

            return index;
        }
        static bool CheckIfIsBigger(int[] arr, int index)
        {
            if ((arr[index] > arr[index - 1]) && (arr[index] > arr[index + 1]))
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
