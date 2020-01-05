using System;

namespace PrimitiveTypesAndVaribles
{
    class Program
    {
        static void Main(string[] args)
        {
            //a
            ushort num1 = 52130;
            sbyte num2 = -115;
            int num3 = 4825932;
            byte num4 = 97;
            short num5 = -10000;
            ushort num6 = 20000;
            byte num7 = 224;
            int num8 = 97;
            uint num9 = 970700000;
            byte num10 = 112;
            sbyte num11 = -44;
            int num12 = -1000000;
            short num13 = 1990;
            ulong num14 = 12345679123456789;

            //b
            double num15 = 34.567839023;
            float num16 = 12.345f;
            float num17 = 8923.1234857f;
            decimal num18 = 3456.091124875956542151256683467m;

            //c
            float x = 0.000001f;
            float y = 1.123456f;

            Console.WriteLine(x + y);

            //d
            int dec = 256;
            int hexa = 0x100;
            Console.WriteLine(hexa);

            //f
            bool isMale = true;

            //g
            string str1 = "Hello";
            string str2 = "World";
            object obj1;
            obj1 = str1 + " " + str2;
            Console.WriteLine(obj1);

            //h
            string str3 = obj1.ToString();
            Console.WriteLine(str3);

            //i
            string str4 = "The \"use\" of quotations causes difficulties.";
            string str5 = @"The ""use"" of quotations causes difficulties.";

            Console.WriteLine(str4);
            Console.WriteLine(str5);

            //j
            Console.WriteLine(@"o
                              o                 o
                             o                   o
                             o
                             o
                              o
                               o
                                o
                                  o
                                     o
                                       o");



            
        }
    }
}
