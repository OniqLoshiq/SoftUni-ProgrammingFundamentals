using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04_HornetArmada
{
    class Legion
    {
        public string Name { get; set; }
        public long Activity { get; set; }
        public Dictionary<string, long> Armada { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"^(?<activity>\d+)(?: = )(?<name>[^\=\->\:\s]+)(?: -> )(?<type>[^\=\->\:\s]+)(?:\:)(?<count>\d+)";

            var allLegions = new Dictionary<string, Legion>();

            GetLegionsData(n, pattern, allLegions);

            string cmd = Console.ReadLine();
            if (cmd.Contains("\\"))
            {
                string[] cmdArgs = cmd.Split('\\');

                foreach (var legion in allLegions
                    .Where(x => x.Value.Armada.ContainsKey(cmdArgs[1]))
                    .Where(z => z.Value.Activity < long.Parse(cmdArgs[0]))
                    .OrderByDescending(c => c.Value.Armada[cmdArgs[1]]))
                {
                    foreach (var armada in legion.Value.Armada
                        .Where(x => x.Key == cmdArgs[1]))
                    {
                        Console.WriteLine($"{legion.Key} -> {armada.Value}");
                    }
                }
            }
            else
            {
                foreach (var legion in allLegions
                    .Where(x => x.Value.Armada.Any(l => l.Key == cmd)).OrderByDescending(z => z.Value.Activity))
                {
                    Console.WriteLine($"{legion.Value.Activity} : {legion.Key}");
                }

            }
        }

        private static void GetLegionsData(int n, string pattern, Dictionary<string, Legion> allLegions)
        {
            for (int i = 0; i < n; i++)
            {
                string inputLine = Console.ReadLine();
                Match match = Regex.Match(inputLine, pattern);

                Legion legion = new Legion();

                legion.Name = match.Groups["name"].Value;
                legion.Activity = long.Parse(match.Groups["activity"].Value);
                string legionType = match.Groups["type"].Value;
                long legionCount = long.Parse(match.Groups["count"].Value);
                legion.Armada = new Dictionary<string, long>();
                legion.Armada.Add(legionType, legionCount);

                if (!allLegions.ContainsKey(legion.Name))
                {
                    allLegions[legion.Name] = new Legion();
                    allLegions[legion.Name].Armada = new Dictionary<string, long>();
                    allLegions[legion.Name].Activity = legion.Activity;
                }

                if (!allLegions[legion.Name].Armada.ContainsKey(legionType))
                {
                    allLegions[legion.Name].Armada[legionType] = 0L;
                }

                allLegions[legion.Name].Armada[legionType] += legionCount;

                if (allLegions[legion.Name].Activity < legion.Activity)
                {
                    allLegions[legion.Name].Activity = legion.Activity;
                }
            }
        }
    }
}
