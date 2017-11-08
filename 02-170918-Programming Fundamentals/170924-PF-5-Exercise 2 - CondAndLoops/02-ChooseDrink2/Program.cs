using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ChooseDrink2
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            double price = 0.0;
            string drink = String.Empty;
            double totalPrice = 0.0;

            if (profession == "Athlete")
            {
                drink = "Water";
                price = 0.7;
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                drink = "Coffee";
                price = 1.0;
            }
            else if (profession == "SoftUni Student")
            {
                drink = "Beer";
                price = 1.7;
            }
            else
            {
                drink = "Tea";
                price = 1.2;
            }

            totalPrice = price * quantity;

            Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");


        }
    }
}
