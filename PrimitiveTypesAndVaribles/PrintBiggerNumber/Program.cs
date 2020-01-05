using System;

namespace PrintBiggerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //read two nums and print the bigger number WITHOUT using conditions 
            Console.Write("X: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Y: ");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Max(x, y));

            Console.WriteLine("Greater: {0}", (x + y + Math.Abs(x - y)) / 2);
            Console.WriteLine("Smaller: {0}", (x + y - Math.Abs(x - y)) / 2);
        }
    }
}
