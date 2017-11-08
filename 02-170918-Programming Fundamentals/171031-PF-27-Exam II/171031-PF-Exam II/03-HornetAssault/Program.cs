using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_HornetAssault
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> beehives = Console.ReadLine().Split().Select(long.Parse).ToList();
            List<long> hornetPower = Console.ReadLine().Split().Select(long.Parse).ToList();

            for (int i = 0; i < beehives.Count; i++)
            {
                long sumHornetPower = hornetPower.Sum();

                if (sumHornetPower <= beehives[i])
                {
                    if(hornetPower.Count <= 0)
                    {
                        break;
                    }
                    beehives[i] -= sumHornetPower;

                    hornetPower.RemoveAt(0);
                }
                else
                {
                    beehives[i] = 0;
                }
            }

            beehives = beehives.Where(x => x != 0).ToList();

            if (beehives.Count == 0)
                Console.WriteLine(string.Join(" ", hornetPower));

            else
                Console.WriteLine(string.Join(" ", beehives));
        }
    }
}
