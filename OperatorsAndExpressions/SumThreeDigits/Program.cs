using System;

namespace SumThreeDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            //sum three digits using the standart input and print the result
            Console.Write("X: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Y: ");
            int y = int.Parse(Console.ReadLine());

            Console.Write("Z: ");
            int z = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Result: {0}", (x + y + z));
        }
    }
}
