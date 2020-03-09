using System;

namespace StringToInt
{
    class Program
    {
        static void Main(string[] args)
        {
            //10. Sum string of integer numbers separated by space
            //for example "10 20 30" -> 60

            string str = "10 20 30";

            string[] strSepareted = SeparateString(str);

            int sum = Sum(strSepareted);

            Console.WriteLine("Sum = " + sum);

        }

        static string[] SeparateString(string str)
        {
            string[] strSeparated = str.Split(" ");

            return strSeparated;
        }

        static int Sum(string[] strArray)
        {
            int sum = 0;

            for (int i = 0; i < strArray.Length; i++)
            {
                sum += Convert.ToInt32(strArray[i]);
            }

            return sum;
        }
    }
}
