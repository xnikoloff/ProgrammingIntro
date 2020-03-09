using System;

namespace UserMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create 3 methods:
            // 1. Method that reverses number
            // 2. Method that calculates average of numbers
            // 3. Method that calculates a * x + b = 0
            // Provide the user a text menu to choose one of the three operations

            Console.WriteLine("Select an option: ");
            Console.WriteLine("1 - Revese a number,\n2 - GetAverage\n3 - Solve a * x + b = 0");

            Console.WriteLine();

            Console.Write("Choise: ");
            byte choise = byte.Parse(Console.ReadLine());

            ProvideMenu(choise);
        }

        static void ProvideMenu(int choise)
        {
            switch (choise)
            {
                case 1:
                    {
                        Console.WriteLine("Input a number to reverse");
                        Console.Write("x: ");
                        int x = int.Parse(Console.ReadLine());

                        while (x > 50000000)
                        {
                            Console.WriteLine("Number is too big!");
                            Console.WriteLine();
                            Console.Write("x: ");
                            x = int.Parse(Console.ReadLine());

                        }

                        int reverse = ReverseNumber(x);
                        Console.WriteLine(reverse);
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("Insert numbers one by one. Use 0 to when you're done.");
                        double average = GetAverage();
                        Console.WriteLine(average);
                        break;

                    }

                case 3:
                    {
                        Console.Write("a: ");
                        int a = int.Parse(Console.ReadLine());

                        Console.Write("b: ");
                        int b = int.Parse(Console.ReadLine());

                        double result = FindX(a, b);
                        Console.WriteLine(result);
                        break;
                    }
            }
        }

        static int ReverseNumber(int number)
        {
            int lastDigit = 0;
            int reverse = 0;

            while (number != 0)
            {
                lastDigit = number % 10;
                reverse = (reverse * 10) + lastDigit;
                number /= 10;
            }
            
            return reverse;
        }

        static double GetAverage()
        {
            double average = 0;
            int counter = 0;
            double sum = 0;

            while (true)
            {
                double x = 0;
                try
                {
                    Console.Write("x: ");
                    x = int.Parse(Console.ReadLine());
                }

                catch (FormatException)
                {
                    Console.WriteLine("Incorect Format or empty sequence!");
                }


                if (x == 0)
                {
                    break;
                }

                sum += x;
                counter++;
            }

            average = sum / counter;

            return average;
        }

        static double FindX(double a, double b)
        {
            if (a == 0 || b == 0)
            {
                Console.WriteLine("A and B must be non-zero");
            }
            double x = 0;

            x = -b / a;

            return x;
        }
    }
}
