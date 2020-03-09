using System;

namespace GetLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get the last digit of a number

            int lastDigit = GetLastDigit(349);
            Console.WriteLine(lastDigit);
        }

        static int GetLastDigit(int x)
        {
            return x % 10;
        }
    }
}
