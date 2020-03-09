using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Methods that takes one argument - string name - and prints it to the console

            Console.Write("Name: ");
            string name = Console.ReadLine();

            PrintName(name);
        }

        static void PrintName(string name)
        {
            Console.WriteLine("Hello, {0}", name);
        }

    }
}
