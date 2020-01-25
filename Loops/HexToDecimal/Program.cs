using System;

namespace HexToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            // program that converts hex number to decimal

            string hex = "F7D";
            double dec = 0;

            for (int i = 0; i < hex.Length; i++)
            {
                if (((int)Char.GetNumericValue(hex[hex.Length - 1 - i]) > 0) && ((int)Char.GetNumericValue(hex[hex.Length - 1 - i]) < 10))
                {
                    dec += (int)Char.GetNumericValue(hex[hex.Length - 1 - i]) * Math.Pow(16, i);
                }

                else if (hex[hex.Length - 1 - i] == 'A')
                {
                    dec += 10 * Math.Pow(16, i);
                }

                else if (hex[hex.Length - 1 - i] == 'B')
                {
                    dec += 11 * Math.Pow(16, i);
                }

                else if (hex[hex.Length - 1 - i] == 'C')
                {
                    dec += 12 * Math.Pow(16, i);
                }

                else if (hex[hex.Length - 1 - i] == 'D')
                {
                    dec += 13 * Math.Pow(16, i);
                }

                else if (hex[hex.Length - 1 - i] == 'E')
                {
                    dec += 14 * Math.Pow(16, i);
                }

                else if (hex[hex.Length - 1 - i] == 'F')
                {
                    dec += 15 * Math.Pow(16, i);
                }
            }

            Console.WriteLine(dec);
        }
    }
}
