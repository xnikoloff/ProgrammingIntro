using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
           //program that converts DECIMAL number to BINARY number

           int n = int.Parse(Console.ReadLine());
            string[] binary = new string[8];

            if (n >= 128)
            {
                n -= 128;
                binary[0] = "1";
            }

            else
            {
                binary[0] = "0";
            }

            if (n >= 64)
            {
                n -= 64;
                binary[1] = "1";
            }

            else
            {
                binary[1] = "0";
            }

            if (n >= 32)
            {
                n -= 32;
                binary[2] = "1";
            }

            else
            {
                binary[2] = "0";
            }

            if (n >= 16)
            {
                n -= 16;
                binary[3] = "1";
            }

            else
            {
                binary[3] = "0";
            }

            if (n >= 8)
            {
                n -= 8;
                binary[4] = "1";
            }

            else
            {
                binary[4] = "0";
            }

            if (n >= 4)
            {
                n -= 4;
                binary[5] = "1";
            }

            else
            {
                binary[5] = "0";
            }

            if (n >= 2)
            {
                n -= 2;
                binary[6] = "1";
            }

            else
            {
                binary[6] = "0";
            }

            if (n >= 1)
            {
                n -= 1;
                binary[7] = "1";
            }

            else
            {
                binary[7] = "0";
            }

            for(int i = 0; i < binary.Length; i++)
            {
                Console.Write(binary[i]);
            }
        }
    }
}
