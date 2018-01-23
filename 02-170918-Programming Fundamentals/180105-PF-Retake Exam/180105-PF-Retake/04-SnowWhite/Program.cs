using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_SnowWhite
{
    class Program
    {
        static void Main(string[] args)
        {
            var dwarfData = new Dictionary<Tuple<string, string>, int>();
            var colors = new Dictionary<string, int>();

            while (true)
            {
                string[] inputData = Console.ReadLine().Split(new string[] { " <:> " }, StringSplitOptions.RemoveEmptyEntries);

                if (inputData[0] == "Once upon a time") break;

                string name = inputData[0];
                string color = inputData[1];
                int physics = int.Parse(inputData[2]);
                var key = new Tuple<string, string>(name, color);

                if (!dwarfData.ContainsKey(key))
                {
                    dwarfData[key] = physics;

                    if (!colors.ContainsKey(color))
                    {
                        colors[color] = 0;
                    }

                    colors[color]++;
                }
                else
                {
                    if (physics > dwarfData[key])
                    {
                        dwarfData[key] = physics;
                    }
                }
            }

            foreach (var dwarf in dwarfData
                .OrderByDescending(x => x.Value)
                .ThenByDescending(x => colors[x.Key.Item2])
                )
            {
                Console.WriteLine("({0}) {1} <-> {2}", dwarf.Key.Item2, dwarf.Key.Item1, dwarf.Value);
            }
        }
    }
}
