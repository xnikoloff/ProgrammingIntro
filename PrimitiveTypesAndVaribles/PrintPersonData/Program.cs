using System;

namespace PrintPersonData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "";
            string surname = "";
            byte age = 0;
            string gender = "";
            long id = 0;

            Console.Write("First name: ");
            firstName = Console.ReadLine();

            Console.Write("Suname: ");
            surname = Console.ReadLine();


            enterAge:
            Console.Write("Age: ");
            age = byte.Parse(Console.ReadLine());

            if (age > 120)
            {
                Console.WriteLine("Are you sure this is the correct age? y/n");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "y":
                        {
                            Console.WriteLine("Pretty amazing but OK.");
                            break;
                        }
                    case "n":
                        {
                            Console.WriteLine("Of course...");
                            goto enterAge;
                        }
                }
            }

            Console.Write("Gender: ");
            gender = Console.ReadLine();

            Console.Write("ID: ");
            id = long.Parse(Console.ReadLine());

            Console.WriteLine("{0} {1}, {2}, {3}, {4}", firstName, surname, age, gender, id);
        }
    }
}
