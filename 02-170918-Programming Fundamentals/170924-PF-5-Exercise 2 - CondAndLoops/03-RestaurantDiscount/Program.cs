using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine().ToLower();

            string room = String.Empty;
            double priceRoom = 0.0;
            double pricePackage = 0.0;
            double pricePerPerson = 0.0;

            if (groupSize <= 50)
            {
                room = "Small Hall";
                priceRoom = 2500.0;
            }
            else if (groupSize <= 100)
            {
                room = "Terrace";
                priceRoom = 5000.0;
            }
            else if (groupSize <= 120)
            {
                room = "Great Hall";
                priceRoom = 7500.0;
            }
           
            if (package == "normal")
            {
                pricePackage = 500.0;
                pricePerPerson = (priceRoom + pricePackage) * 0.95 / groupSize;
            }
            else if (package == "gold")
            {
                pricePackage = 750.0;
                pricePerPerson = (priceRoom + pricePackage) * 0.9 / groupSize;
            }
            else if (package == "platinum")
            {
                pricePackage = 1000.0;
                pricePerPerson = (priceRoom + pricePackage) * 0.85 / groupSize;
            }

            if (groupSize <= 120)
                Console.WriteLine("We can offer you the {0}{1}The price per person is {2:f2}$", room, Environment.NewLine, pricePerPerson);
            else Console.WriteLine("We do not have an appropriate hall.");

            }
    }
}
