using System;

namespace LargestAndSmallestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // print the largest and the smallest number of n numbers

            byte n = 0;
            Console.Write("Count: "); // set count
            byte count = byte.Parse(Console.ReadLine());
            byte max = byte.MinValue;
            byte min = byte.MaxValue;

            for (int i = 0; i < count; i++)
            {
                Console.Write("n: ");
                n = byte.Parse(Console.ReadLine());

                //check if there is new largest number
                if (n > max)
                {
                    max = n;
                }

                //check if there is new smallest number
                else if (n < min)
                {
                    min = n;
                }


                else
                {
                    Console.WriteLine("Error!");
                }
            }

            //print the numbers
            Console.WriteLine("Min: {0}, Max: {1}", min, max);
        }
    }
}
