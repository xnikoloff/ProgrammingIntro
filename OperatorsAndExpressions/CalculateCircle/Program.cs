using System;

namespace CalculateCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            //calculte P, S and D of circle and print the result
            Console.Write("r: ");
            double r = double.Parse(Console.ReadLine());

            double p = (2 * Math.PI) * r;
            double s = Math.PI * (r * r);
            double d = r * r;

            Console.WriteLine("P: {0:f2}, S: {1:f2}, D: {2:f2}", p, s, d);


        }
    }
}
