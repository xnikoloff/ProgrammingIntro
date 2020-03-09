using System;

namespace WorkingDays
{
    class Program
    {
        //holidays of Bulgarian calendar
        static DateTime[] holidays = new DateTime[]
        {
            new DateTime(2020, 01, 01), //New Year's day
            new DateTime(2020, 03, 03), //Liberation of Bulgaria
            new DateTime(2020, 04, 17), //Good Friday
            new DateTime(2020, 04, 20), //Easter Monday
            new DateTime(2020, 05, 06), //St George's Day
            new DateTime(2020, 05, 25), //25th of May
            new DateTime(2020, 09, 07), //7th of September
            new DateTime(2020, 09, 22), //Independence day
            new DateTime(2020, 12, 24), //Christmas Eve
            new DateTime(2020, 12, 28), //Second Day of Christmas
        };
        static void Main(string[] args)
        {
            //Create a program that calculates the number of working days
            //from today's date to a another date 
            //e.g from today(03.08.2020) to 22.04.2020
            //working days are all days except weekend and 
            //official holidays
            //(!DATES ARE VALID FOR THE BULGARIAN CALENDAR!).

            DateTime start = new DateTime(2020, 05, 02);
            DateTime end = new DateTime(2020, 05, 22);

            int workingDays = GetWorkingDays(start, end);

            Console.WriteLine(workingDays);
        }

        static int GetWorkingDays(DateTime startDate, DateTime endDate)
        {
            int counter = 0;

            DateTime workDays;

            //loop through days and add one day at each loop
            for (workDays = startDate; workDays <= endDate; workDays = workDays.AddDays(1))
            {
                //loop through the holidays array
                for (int j = 0; j < holidays.Length; j++)
                {
                    //check if there is a match with some of the holidays
                    if (workDays == holidays[j])
                    {
                        //if there is a match, substract one day from the days count
                        counter--;
                    }
                }

                //check if the day is Sunday or Saturday
                if (workDays.DayOfWeek.ToString() == "Saturday"
                || workDays.DayOfWeek.ToString() == "Sunday")
                {
                    //if it is, continue with the next itearation
                    continue;
                }

                //add one working day at each loop 
                counter++;

            }

            return counter;
        }
    }
}
