using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            string legendaryItem = String.Empty;
            
            var keyMaterials = new Dictionary<string, int>();
            keyMaterials["shards"] = 0;
            keyMaterials["fragments"] = 0;
            keyMaterials["motes"] = 0;

            var junkMaterials = new Dictionary<string, int>();

            bool checker = true;

            while (checker == true)
            {
                string[] inputLine = Console.ReadLine().ToLower().Split();
                List<string> materials = inputLine.Where((x, y) => y % 2 != 0).ToList();
                List<int> quantities = inputLine.Where((x, y) => y % 2 == 0).Select(int.Parse).ToList();

                for (int i = 0; i < materials.Count; i++)
                {
                    if (keyMaterials.ContainsKey(materials[i]))
                    {
                        keyMaterials[materials[i]] += quantities[i];

                        if (keyMaterials["shards"] >= 250)
                        {
                            legendaryItem = "Shadowmourne";
                            keyMaterials["shards"] -= 250;
                            checker = false;
                            break;
                        }
                        else if (keyMaterials["fragments"] >= 250)
                        {
                            legendaryItem = "Valanyr";
                            keyMaterials["fragments"] -= 250;
                            checker = false;
                            break;
                        }
                        else if (keyMaterials["motes"] >= 250)
                        {
                            legendaryItem = "Dragonwrath";
                            keyMaterials["motes"] -= 250;
                            checker = false;
                            break;
                        }
                    }
                    else if (!junkMaterials.ContainsKey(materials[i]))
                    {
                        junkMaterials[materials[i]] = quantities[i];
                    }
                    else
                    {
                        junkMaterials[materials[i]] += quantities[i];

                    }
                }
            }

            Console.WriteLine("{0} obtained!", legendaryItem);

            foreach (KeyValuePair<string, int> item in keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine("{0}: {1}", item.Key, item.Value);

            }
            foreach (var item in junkMaterials.OrderBy(x => x.Key))
            {
                Console.WriteLine("{0}: {1}", item.Key, item.Value);
            }
        }
    }
}
