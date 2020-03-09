using System;

namespace FindHypotenuse
{
    class Program
    {
        static void Main(string[] args)
        {
            //You're given two of the sides of a  triangle. Find the hypotenuse of a right triangle
            
            Console.Write("side a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("side b: ");
            double b = double.Parse(Console.ReadLine());

            //The Pythagorean Theorem
            double c2 = Math.Pow(a, 2) + Math.Pow(b, 2);

            double c = Math.Sqrt(c2);
            Console.WriteLine($"Hypotenuse: {c:f2}");
        }
    }
}
