using System;

namespace GetMax
{
    class Program
    {
        static void Main(string[] args)
        {
            //Find the max number of two numbers

            int max = GetMax(4, 8);
            Console.WriteLine(max);
        }

        static int GetMax(int x, int y)
        {
            if (x > y)
            {
                return x;
            }

            else
            {
                return y;
            }

        }
    }
}
