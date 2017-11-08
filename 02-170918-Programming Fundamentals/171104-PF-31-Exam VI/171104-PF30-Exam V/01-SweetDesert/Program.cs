using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SweetDesert
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal cash = decimal.Parse(Console.ReadLine());
            int guests = int.Parse(Console.ReadLine());
            decimal priceBananas = decimal.Parse(Console.ReadLine());
            decimal priceEggs = decimal.Parse(Console.ReadLine());
            decimal priceBerries = decimal.Parse(Console.ReadLine());

            int sets = 0;

            if (guests % 6 == 0)
            {
                sets = guests / 6;
            }
            else
            {
                sets = (guests / 6) + 1;
            }

            decimal allProductsMoney = sets * (priceBananas * 2 + priceBerries * 0.2M + priceEggs * 4.0M);

            if(allProductsMoney <= cash)
                Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.", allProductsMoney);

            else
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.", allProductsMoney - cash);

        }
    }
}
