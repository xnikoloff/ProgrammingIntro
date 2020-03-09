using System;

namespace IsThirdDigitSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            //check if number is divisible by 5 and 7
            Console.Write("number: ");
            int x = int.Parse(Console.ReadLine());
            string sevendAndSix = (x % 5 == 0 && x % 7 == 0) ? x + " is divisible by 5 and 7" : x + " is not divisible by 5 and 7";
            Console.WriteLine(sevendAndSix);
        }
    }
}
