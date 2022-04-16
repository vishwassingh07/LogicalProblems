using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class DayOfWeek
    {
        int y, m;
        public void Day()
        {
            Console.WriteLine("Enter the month between 1 and 12 : ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the day between 1 and 7 : ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the year :");
            int year = Convert.ToInt32(Console.ReadLine());

            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = month + 12 * ((14 - month) / 12) - 2;
            int d0 = (day + x + 31 * m0) % 7;

            switch (d0)
            {
                case 0:
                    Console.WriteLine("Today is Sunday");
                    break;
                case 1:
                    Console.WriteLine("Today is Monday");
                    break;
                case 2:
                    Console.WriteLine("Today is Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Today is Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Today is Thursday");
                    break;
                case 5:
                    Console.WriteLine("Today is Friday");
                    break;
                case 6:
                    Console.WriteLine("Today is Saturday");
                    break;
            }

        }
    }
}
