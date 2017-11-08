using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CountWorkingDays
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            DateTime[] holidays = new DateTime[11];
            holidays[0] = new DateTime (4, 1 , 1);
            holidays[1] = new DateTime(4, 3, 3);
            holidays[2] = new DateTime(4, 5, 1);
            holidays[3] = new DateTime(4, 5, 6);
            holidays[4] = new DateTime(4, 5, 24);
            holidays[5] = new DateTime(4, 9, 6);
            holidays[6] = new DateTime(4, 9, 22);
            holidays[7] = new DateTime(4, 11, 1);
            holidays[8] = new DateTime(4, 12, 24);
            holidays[9] = new DateTime(4, 12, 25);
            holidays[10] = new DateTime(4, 12, 26);


            TimeSpan totalDays = secondDate.Subtract(firstDate);
            int counter = 0;

            for (DateTime i = firstDate; i <= secondDate; i = i.AddDays(1))
            {
                DateTime check = new DateTime(4, i.Month, i.Day);
                if(i.DayOfWeek != DayOfWeek.Saturday && i.DayOfWeek != DayOfWeek.Sunday && !holidays.Contains(check))
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
