using System;

namespace MetricUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            string unit = "";
            string unitChoise = "";
            printUnits();

            unitChoise = Console.ReadLine();
            assignUnits(unitChoise);
            

            Console.Write("a: ");
            double side = double.Parse(Console.ReadLine());

            Console.Write("h:");
            double height = double.Parse(Console.ReadLine());

            double p = calculatePerimeter(side, height);
            double s = calculateArea(side, height);

            Console.WriteLine("P: {0} {1}, S: {2} {3}", p, unit, s, unit);

            void printUnits()
            {
                Console.WriteLine("Please select a metric unit: ");

                string[] metrics = { "mm", "cm", "dc", "m", "km" };

                for (int i = 0; i < metrics.Length; i++)
                {
                    if (i != metrics.Length - 1)
                    {
                        Console.Write(metrics[i] + ", ");
                    }

                    else
                    {
                        Console.WriteLine(metrics[metrics.Length - 1]);
                    }

                }
            }

            void assignUnits(string unitChoise)
            {
                switch (unitChoise)
                {
                    case "mm":
                        {
                            unit = "mm";
                            break;
                        }
                    case "cm":
                        {
                            unit = "cm";
                            break;
                        }
                    case "dm":
                        {
                            unit = "dm";
                            break;
                        }
                    case "m":
                        {
                            unit = "m";
                            break;
                        }
                    case "km":
                        {
                            unit = "km";
                            break;
                        }
                }

            }

            static double calculateArea(double side, double height)
            {
                return (side * height) * 2;
            }

            static double calculatePerimeter(double side, double height)
            {
                return side * height;
            }
            
        }
    }
}
