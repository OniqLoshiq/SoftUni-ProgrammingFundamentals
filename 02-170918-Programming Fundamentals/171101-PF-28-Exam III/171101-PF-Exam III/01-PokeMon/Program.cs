using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distanceBtwnPkms = int.Parse(Console.ReadLine());
            int exhaustFact = int.Parse(Console.ReadLine());

            int pokedCount = 0;

            double halfPokePower = pokePower / 2.0;

            if (halfPokePower % distanceBtwnPkms == 0.0)
            {
                while (pokePower >= distanceBtwnPkms)
                {
                    pokedCount++;

                    pokePower -= distanceBtwnPkms;

                    if (halfPokePower == pokePower && exhaustFact != 0)
                    {
                        pokePower = pokePower / exhaustFact;
                    }
                }
            }
            else
            {
                while (pokePower >= distanceBtwnPkms)
                {
                    pokedCount++;

                    pokePower -= distanceBtwnPkms;
                }

            }
            Console.WriteLine(pokePower);
            Console.WriteLine(pokedCount);
        }
    }
}
