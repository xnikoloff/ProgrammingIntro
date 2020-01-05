using System;

namespace AscendingAndDescending
{
    class Program
    {
        static void Main(string[] args)
        {
            //sort three numbers in descending or ascendung order
            byte a = 1;
            byte b = 8;
            byte c = 4;
            byte smaller = 0, middle = 0, largest = 0;

            Console.WriteLine("Ascending = 1, Desceing = 2");
            Console.Write("Input: ");

            byte choise = byte.Parse(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    {
                        if (a > b && a > c)
                        {
                            largest = a;

                            if (b > c)
                            {
                                middle = b;
                                smaller = c;
                            }

                            else
                            {
                                middle = c;
                                smaller = b;
                            }
                        }

                        else if (b > a && b > c)
                        {
                            largest = b;

                            if (a > c)
                            {
                                middle = a;
                                smaller = c;
                            }

                            else
                            {
                                middle = c;
                                smaller = a;
                            }
                        }

                        else
                        {
                            largest = c;
                            if (a > b)
                            {
                                middle = a;
                                smaller = b;
                            }

                            else
                            {
                                smaller = a;
                                middle = b;
                            }
                        }
                        Console.WriteLine("{0}, {1}, {2}", smaller, middle, largest);
                        break;
                    }

                case 2:
                    {
                        if (a < b && a < c)
                        {
                            smaller = a;

                            if (b < c)
                            {
                                middle = b;
                                largest = c;
                            }

                            else
                            {
                                middle = c;
                                largest = b;
                            }

                        }
                        Console.WriteLine("{0}, {1}, {2}", largest, middle, smaller);

                        break;
                    }
            }
        }
    }
}
