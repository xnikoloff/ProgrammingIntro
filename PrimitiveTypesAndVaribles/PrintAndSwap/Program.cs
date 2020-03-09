using System;

namespace PrintAndSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            // print two numbers and then swap their places
            int fNum = 5;
            int secNum = 10;
            int temp = fNum;
            Console.WriteLine("{0}\n{1}", fNum, secNum);
            fNum = secNum;
            secNum = temp;
            Console.WriteLine("{0}\n{1}", fNum, secNum);
        }
    }
}
