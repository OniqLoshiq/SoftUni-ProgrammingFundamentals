using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int enCont = int.Parse(Console.ReadLine());
            int sugCont = int.Parse(Console.ReadLine());

            double energy = enCont / 100.0 * volume;
            double sugar = sugCont / 100.0 * volume;


            Console.WriteLine($"{volume}ml {name}:{Environment.NewLine}{energy}kcal, {sugar}g sugars");

        }
    }
}
