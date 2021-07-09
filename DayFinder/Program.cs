using System;

namespace DayFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the month number between 1 to 12");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the day");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the year in format YYYY");
            int y = Convert.ToInt32(Console.ReadLine());
            DayOfWeek(m, d, y);
        }
        static void DayOfWeek(int month, int day, int year)
        {
            int m = month, d = day, y = year;
            int m1, d1, y1, x;
            y1 = y - (14 - m) / 12;
            x = y1 + (y1 / 4) - (y1 / 100) + (y1 / 400);
            m1 = m + 12 * ((14 - m) / 12) - 2;
            d1 = (d + x + 31 * m1 / 12) % 7;
            toString(d1);
        }
        static void toString(int d1)
        {
            switch (d1)
            {
                case 0:
                    Console.WriteLine("Sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
            }
        }
    }
}
