using System;

namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print 10 random numbers(100 - 200)
            
            Random random = new Random();

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(random.Next(100, 200) + 1);
            }
        }
    }
}
