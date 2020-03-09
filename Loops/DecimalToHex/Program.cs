using System;

namespace DecimalToHex
{
    class Program
    {
        static void Main(string[] args)
        {
            // program that converts decimal number to hexadecimal
            double dec = double.Parse(Console.ReadLine());
            double remainder = 1;
            string hexaDecimal = "";

            while (dec >= 1)
            {
                dec = dec / 16;

                int remainderTemp = (int)dec;
                remainder = dec - remainderTemp;

                remainder *= 16;
                int remainderCasted = (int)remainder;
                if (remainderCasted > 0 && remainderCasted < 10)
                {
                    hexaDecimal += remainderCasted.ToString();
                }

                else if (remainderCasted == 10)
                {
                    hexaDecimal += "A";
                }

                else if (remainderCasted == 11)
                {
                    hexaDecimal += "B";
                }

                else if (remainderCasted == 12)
                {
                    hexaDecimal += "C";
                }

                else if (remainderCasted == 13)
                {
                    hexaDecimal += "D";
                }

                else if (remainderCasted == 14)
                {
                    hexaDecimal += "E";
                }

                else if (remainderCasted == 15)
                {
                    hexaDecimal += "F";
                }

            }
            char[] cArray = hexaDecimal.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }

            Console.WriteLine(reverse);
        }
    }
}
