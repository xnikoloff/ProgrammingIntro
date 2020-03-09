using System;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input an year(integer) to the console and check if it is a leap year
            
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());

            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine($"{year} is a leap year");
            }

            else
            {
                Console.WriteLine($"{year} is not a leap year");
            }
        }
    }
}
