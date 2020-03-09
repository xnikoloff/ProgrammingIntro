using System;

namespace SumAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //sum the digits of a number and reverse it

            //fillArray
            Console.Write("Num: ");
            short number = short.Parse(Console.ReadLine());

            string[] charsOfNumber = new string[number.ToString().Length];

            byte counter = 0;
            foreach (char s in number.ToString())
            {
                charsOfNumber[counter] += s;
                counter++;
            }

            //a. sum digits of number
            int sum = 0;

            for (int i = 0; i < charsOfNumber.Length; i++)
            {
                //convert array to int
                sum += Int32.Parse(charsOfNumber[i]);
                Console.Write(charsOfNumber[i] + " ");
            }

            Console.Write("= ");
            Console.WriteLine(sum);


            //b. reverse result
            Array.Reverse(charsOfNumber, 0, charsOfNumber.Length);

            for (int i = 0; i < charsOfNumber.Length; i++)
            {
                Console.Write(charsOfNumber[i]);
            }

            Console.WriteLine();
            //reverse array by algorithm

            int rev = 0;
            int numberTemp = number;

            while (numberTemp > 0)
            {
                rev = (rev * 10) + (numberTemp % 10);
                numberTemp /= 10;
            }

            Console.WriteLine(rev + " by alogorithm");
        }
    }
}
