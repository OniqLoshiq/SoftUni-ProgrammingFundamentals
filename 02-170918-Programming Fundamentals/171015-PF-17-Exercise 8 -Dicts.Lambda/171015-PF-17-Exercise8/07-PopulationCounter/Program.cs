using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var populationData = new Dictionary<string, Dictionary<string, long>>();

            string input = Console.ReadLine();

            while (input != "report")
            {
                string[] inputLine = input.Split('|').ToArray();

                string country = inputLine[1];
                string city = inputLine[0];
                long cityPopulation = long.Parse(inputLine[2]);

                if (!populationData.ContainsKey(country))
                {
                    populationData[country] = new Dictionary<string, long>();
                }
                if (!populationData[country].ContainsKey(city))
                {
                    populationData[country][city] = cityPopulation;
                }

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, Dictionary<string, long>> country in populationData.OrderByDescending(x => x.Value.Sum(y => y.Value)))
            {
                Console.WriteLine("{0} (total population: {1})", country.Key, country.Value.Sum(x => x.Value));
                foreach (var city in country.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine("=>{0}: {1}", city.Key, city.Value);
                }
            }

        }
    }
}
