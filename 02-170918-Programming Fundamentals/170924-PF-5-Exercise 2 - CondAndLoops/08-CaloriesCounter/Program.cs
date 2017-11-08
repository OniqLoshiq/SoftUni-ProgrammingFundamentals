using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int caloriesCheese = 500;
            int caloriesSauce = 150;
            int caloriesSalami = 600;
            int caloriesPepper = 50;

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                string ingredient = Console.ReadLine().ToLower();
                switch (ingredient)
                {
                    case "cheese": sum += caloriesCheese; break;
                    case "tomato sauce": sum += caloriesSauce; break;
                    case "salami": sum += caloriesSalami; break;
                    case "pepper": sum += caloriesPepper; break;
                    default: sum += 0;
                        break;
                }
            }

            Console.WriteLine("Total calories: {0}", sum);
        }
    }
}
