using System;

namespace PrintCompanyData
{
    class Program
    {
        static void Main(string[] args)
        {
            //print company data
            //the company has address, phone, fax, website and manager
            //the manager of the company has first name, last name and phone

            Console.WriteLine("The Company");
            Console.Write("Adress: ");
            string address = Console.ReadLine();

            Console.Write("Phone: ");
            string phone = Console.ReadLine();

            Console.Write("Fax: ");
            string fax = Console.ReadLine();

            Console.Write("Website: ");
            string website = Console.ReadLine();

            Console.Write("Manager: ");
            string manager = Console.ReadLine();

            Console.WriteLine();

            Console.Write("The Manager: ");


            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Last name: ");
            string surname = Console.ReadLine();

            Console.Write("Phone: ");
            string managerPhone = Console.ReadLine();

            Console.WriteLine("=============================");

            Console.WriteLine("Company Info: ");
            Console.WriteLine("Address: {0}, Phone: {1}, Fax: {2}, Website: {3}, Manager: {4}", address, phone, fax, website, manager);

            Console.WriteLine("-------------------------");

            Console.WriteLine("Manager Info: ");
            Console.WriteLine("Name: {0}, Surname: {1}, Phone: {2}", name, surname, managerPhone);
        }
    }
}
