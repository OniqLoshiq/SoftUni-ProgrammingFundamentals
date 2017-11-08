using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_PokemonEvolve
{
    class Pokemon
    {
        public string Name { get; set; }
        public string EvoType { get; set; }
        public int EvoIndex { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var allPokemons = new Dictionary<string, List<Pokemon>>();

            while (true)
            {
                string[] inputLine = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (inputLine[0] == "wubbalubbadubdub")
                {
                    break;
                }
                else if (inputLine.Length == 1)
                {
                    foreach (var pokemon in allPokemons.Where(x => x.Key == inputLine[0]))
                    {
                        Console.WriteLine($"# {pokemon.Key}");

                        foreach (var poke in pokemon.Value)
                        {
                            Console.WriteLine($"{poke.EvoType} <-> {poke.EvoIndex}");
                        }
                    }

                    continue;
                }

                Pokemon pokemoke = new Pokemon();
                pokemoke.Name = inputLine[0];
                pokemoke.EvoType = inputLine[1];
                pokemoke.EvoIndex = int.Parse(inputLine[2]);

                if (!allPokemons.ContainsKey(pokemoke.Name))
                {
                    allPokemons[pokemoke.Name] = new List<Pokemon>();
                }
                allPokemons[pokemoke.Name].Add(pokemoke);
            }

            foreach (var pokemon in allPokemons)
            {
                Console.WriteLine($"# {pokemon.Key}");

                foreach (var poke in pokemon.Value.OrderByDescending(x => x.EvoIndex))
                {
                    Console.WriteLine($"{poke.EvoType} <-> {poke.EvoIndex}");
                }
            }
        }
    }
}
