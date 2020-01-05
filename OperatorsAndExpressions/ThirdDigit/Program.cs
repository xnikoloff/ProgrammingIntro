using System;

namespace ThirdDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            //check if third digit of number is 7
            Console.WriteLine("Press 0 to exit");
            while (true)
            {
                Console.Write("Enter a 3 digit number: ");
                int num = int.Parse(Console.ReadLine());
                string numberToString = num.ToString();

                if (numberToString.Length == 3)
                {
                    string isThirdDigit7 = (numberToString.Substring(2) == "7") ? "Third digit of " + numberToString + " is 7" : "Third digit of " + num + " is not 7";
                    Console.WriteLine(isThirdDigit7);
                }

                else if (num == 0)
                {
                    break;
                }
            }
        }
    }
}
