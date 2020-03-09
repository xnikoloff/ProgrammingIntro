using System;

namespace BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            //program that converts BINARY number to DECIMAL number

            string binary = "10101001";
            double dec = 0;

            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[(binary.Length - 1) - i] != '0')
                {
                    dec += Math.Pow(2, i);
                }
            }

            Console.WriteLine(dec);
        }
    }
}
