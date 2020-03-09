using System;

namespace TimePassedSincePCIsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print how many days, hours, minutes and seconds have passed 
            //from the pc start to the program execution
            
            int time = Environment.TickCount;
            int sec = time / 1000;
            int minutes = sec / 60;
            int hours = minutes / 60;
            int days = hours / 24;

            Console.WriteLine($"Days: {days}, Hours: {hours}, Minutes: {minutes}, Seconds: {sec}");
        }
    }
}
