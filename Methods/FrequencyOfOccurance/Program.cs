using System;

namespace FrequencyOfOccurance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input a number to be searched into the array 
            //and output how many of this number are in the array
            int[] arr = { 2, 5, 2, 4, 2, 6, 14, 3, 2, 3 };

            Console.Write("Number: ");
            int x = int.Parse(Console.ReadLine());

            int frequency = GetFrequencyOfOccurance(arr, x);

            if (frequency != 0)
            {
                Console.WriteLine("The frequency of occurance of {0} is {1}", x, frequency);
            }

            else
            {
                Console.WriteLine("This number does not exists in this array!");
            }
        }

        static int GetFrequencyOfOccurance(int[] arr, int x)
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (x == arr[i])
                {
                    count++;
                }
            }

            return count;
        }
    }
}
