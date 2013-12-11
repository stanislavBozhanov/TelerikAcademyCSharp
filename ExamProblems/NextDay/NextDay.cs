// Enter date -> Prints NextDay
using System;
using System.Linq;

namespace NextDay
{
    class NextDay
    {
        static void Main()
        {
            int day = int.Parse(Console.ReadLine()) + 1;
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int feb = year % 4 == 0 ? 29 : 28;
            int[] calendarArray = { 0, 31, feb, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (calendarArray[month] < day)
            {
                day = 1;
                month++;
            }
            if (month == 13)
            {
                day = 1;
                month = 1;
                year++;
            }
            Console.WriteLine(day + "." + month + "." + year); 
        }
    }
}
