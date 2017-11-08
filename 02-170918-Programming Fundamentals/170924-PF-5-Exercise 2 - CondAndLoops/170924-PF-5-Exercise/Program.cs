using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _170924_PF_5_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();

            string drink = String.Empty;

            switch (profession)
            {
                case "Athlete": drink = "Water"; break;
                case "Businessman":
                case "Businesswoman": drink = "Coffee";break;
                case "SoftUni Student": drink = "Beer";break;
                default: drink = "Tea"; break;
            }
            Console.WriteLine(drink);
        }
    }
}
