using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string resource = Console.ReadLine();

            Dictionary<string, long> resourcesQuantities = new Dictionary<string, long>();

            while (resource != "stop")
            {
                long quantity = long.Parse(Console.ReadLine());

                if(resourcesQuantities.ContainsKey(resource))
                {
                    resourcesQuantities[resource] += quantity;
                }
                else
                {
                    resourcesQuantities[resource] = quantity;
                }

                resource = Console.ReadLine();
            }
            foreach (var input in resourcesQuantities)
            {
                Console.WriteLine("{0} -> {1}", input.Key, input.Value);
            }
        }
    }
}
