using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CoffeeOrders
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            decimal orderPrice = 0.0M;
            decimal totalOrderPrice = 0.0M;

            for (int i = 0; i < n; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                uint capsulesCount = uint.Parse(Console.ReadLine());
                int days = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);

                orderPrice = days * capsulesCount * pricePerCapsule;
                Console.WriteLine("The price for the coffee is: ${0:f2}", orderPrice);

                totalOrderPrice += orderPrice;
            }

            Console.WriteLine($"Total: ${totalOrderPrice:f2}");
        }
    }
}
