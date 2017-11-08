using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            var dragonsData = new Dictionary<string, Dictionary<string, List<double>>>();

            GetDragonsData(n, dragonsData);

            foreach (KeyValuePair<string, Dictionary<string, List<double>>> dragonType in dragonsData)
            {
                string dragonColor = dragonType.Key;
                List<string> dragonNames = dragonType.Value.Keys.ToList();

                double averageDamage = dragonType.Value.Select(x => x.Value[0]).Average();
                double averageHealth = dragonType.Value.Select(x => x.Value[1]).Average();
                double averageArmor = dragonType.Value.Select(x => x.Value[2]).Average();

                Console.WriteLine("{0}::({1:f2}/{2:f2}/{3:f2})", dragonColor, averageDamage, averageHealth, averageArmor);

                foreach (var dragon in dragonType.Value.OrderBy(x => x.Key))
                {
                    Console.WriteLine("-{0} -> damage: {1}, health: {2}, armor: {3}",
                        dragon.Key, dragon.Value[0], dragon.Value[1], dragon.Value[2]);
                }
            }
        }

        private static void GetDragonsData(double n, Dictionary<string, Dictionary<string, List<double>>> dragonsData)
        {
            for (double i = 0; i < n; i++)
            {
                string[] inputLine = Console.ReadLine().Split();
                string dragonType = inputLine[0];
                string dragonName = inputLine[1];

                double damage = 0.0;
                double health = 0.0;
                double armor = 0.0;

                if (inputLine[2] == "null") { damage = 45.0; }
                else { damage = double.Parse(inputLine[2]); }

                if (inputLine[3] == "null") { health = 250.0; }
                else { health = double.Parse(inputLine[3]); }

                if (inputLine[4] == "null") { armor = 10.0; }
                else { armor = double.Parse(inputLine[4]); }

                if (!dragonsData.ContainsKey(dragonType))
                {
                    dragonsData[dragonType] = new Dictionary<string, List<double>>();
                }
                if (!dragonsData[dragonType].ContainsKey(dragonName))
                {
                    dragonsData[dragonType][dragonName] = new List<double> { damage, health, armor };
                }
                dragonsData[dragonType][dragonName] = new List<double> { damage, health, armor };

            }
        }
    }
}

