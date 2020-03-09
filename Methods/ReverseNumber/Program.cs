using System;

namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Method that reverse number

            int number = ReverseNumber(186);
            Console.WriteLine(number);
        }

        static int ReverseNumber(int number)
        {
            int lastDigit = 0;
            int reverse = 0;

            while (number != 0)
            {
                lastDigit = number % 10;
                reverse = (reverse * 10) + lastDigit;
                number /= 10;
            }



            return reverse;
        }
    }
}
