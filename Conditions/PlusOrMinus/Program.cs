using System;

namespace PlusOrMinus
{
    class Program
    {
        static void Main(string[] args)
        {
            //calculate the result and print plus or minus 
            int a = 3;
            int b = 8;
            int c = 0;

            if (a * b * c > 0)
            {
                Console.WriteLine("+");
            }

            else if (a * b * c == 0)
            {
                Console.WriteLine(0);
            }

            else if (a * b * c < 0)
            {
                Console.WriteLine("-");
            }
        }
    }
}
