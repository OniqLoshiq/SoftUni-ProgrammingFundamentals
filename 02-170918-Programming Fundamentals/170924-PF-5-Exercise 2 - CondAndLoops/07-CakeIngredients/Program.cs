using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            string ingredient = Console.ReadLine();

            Console.WriteLine("Adding ingredient {0}.", ingredient);
            while (ingredient != "Bake!")
            {
                ingredient = Console.ReadLine();
                if (ingredient == "Bake!") break;
                Console.WriteLine("Adding ingredient {0}.", ingredient);
                counter++;
            }
            Console.WriteLine("Preparing cake with {0} ingredients.", counter);
        }
    }
}
