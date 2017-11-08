using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            int nights = int.Parse(Console.ReadLine());

            double totalPriceStudio = 0.0;
            double totalPriceDouble = 0.0;
            double totalPriceSuite = 0.0;

            if (month == "may" || month == "october")
            {
                totalPriceStudio = 50.0 * nights;
                totalPriceDouble = 65.0 * nights;
                totalPriceSuite = 75.0 * nights;

                if (nights > 7 && month == "october")
                {
                    totalPriceStudio = (totalPriceStudio - 50) * 0.95;
                }
                else if (nights > 7)
                {
                    totalPriceStudio *= 0.95;
                }
            }
            else if (month == "june" || month == "september")
            {
                totalPriceStudio = 60.0 * nights;
                totalPriceDouble = 72.0 * nights;
                totalPriceSuite = 82.0 * nights;

                if (nights > 7 && month == "september")
                {
                    totalPriceStudio = (totalPriceStudio - 60);
                }
                else if (nights > 14)
                {
                   totalPriceDouble *= 0.9;
                }
            }
            else if (month == "july" || month == "august" || month == "december")
            {
                totalPriceStudio = 68.0 * nights;
                totalPriceDouble = 77.0 * nights;
                totalPriceSuite = 89.0 * nights;

                if (nights > 14)
                {
                    totalPriceSuite *= 0.85;
                }
            }

            Console.WriteLine("Studio: {0:f2} lv.", totalPriceStudio);
            Console.WriteLine("Double: {0:f2} lv.", totalPriceDouble);
            Console.WriteLine("Suite: {0:f2} lv.", totalPriceSuite);
        }
    }
}
