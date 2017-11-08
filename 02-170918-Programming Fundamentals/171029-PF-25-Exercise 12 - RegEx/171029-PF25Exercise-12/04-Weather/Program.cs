using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04_Weather
{
    class CityWeather
    {
        public double avgTemp { get; set; }
        public string weathType { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();

            var allCities = new Dictionary<string, CityWeather>();

            while (inputLine != "end")
            {
                string pattern = @"(?<city>[A-Z]{2})(?<temperature>[0-9]{1,2}.[0-9]{1,2})(?<weatherType>[A-Za-z][a-z]+)(?=\|)";
                MatchCollection validData = Regex.Matches(inputLine, pattern);

                foreach (Match data in validData)
                {
                    string nameCode = data.Groups["city"].Value;

                    if (!allCities.ContainsKey(nameCode))
                    {
                        allCities[nameCode] = new CityWeather();
                    }
                    allCities[nameCode].avgTemp = double.Parse(data.Groups["temperature"].Value);
                    allCities[nameCode].weathType = data.Groups["weatherType"].Value;
                }

                inputLine = Console.ReadLine();
            }

            foreach (var city in allCities.OrderBy(x => x.Value.avgTemp))
            {
                Console.WriteLine("{0} => {1:f2} => {2}", city.Key, city.Value.avgTemp, city.Value.weathType);
            }

        }
    }
}

