using System;

namespace SumFiveNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //sum five numbers 
            //if input is wrong, prompt the user to input a number again

            double result = 0;
            short counter = 0;

            while (counter < 5)
            {
                try
                {
                    Console.WriteLine("Enter a number: ");
                    double number = double.Parse(Console.ReadLine());
                    result += number;
                    counter++;
                }

                catch (FormatException e)
                {
                    Console.WriteLine("Wrong Input!");
                }

            }

            Console.WriteLine(result);
        }
    }
}
