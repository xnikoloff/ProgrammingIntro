using System;

namespace WeightOnMoon
{
    class Program
    {
        static void Main(string[] args)
        {
            //calculate your weight on moon (17% of the weight on Earth)
            Console.WriteLine("Your weight: ");
            double weightOnEarth = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f2}", weightOnEarth * .17);
        }
    }
}
