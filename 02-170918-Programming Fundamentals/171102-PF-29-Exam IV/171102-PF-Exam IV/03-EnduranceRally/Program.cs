using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_EnduranceRally
{
    class Racer
    {
        public string Name { get; set; }
        public double Fuel { get; set; }
        public int ReachedIndex { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<string> racers = Console.ReadLine().Split().ToList();
            List<double> track = Console.ReadLine().Split().Select(double.Parse).ToList();
            List<int> checkpoints = Console.ReadLine().Split().Select(int.Parse).ToList();

            bool[] isCheckPoint = new bool[track.Count];

            if (checkpoints.Count > 0)
            {
                for (int i = 0; i < checkpoints.Count; i++)
                {
                    if(checkpoints[i] < track.Count && checkpoints[i] >= 0)
                    isCheckPoint[checkpoints[i]] = true;
                }
            }

            var allRacers = new List<Racer>();

            foreach (var racer in racers)
            {
                Racer thisRacer = new Racer();
                thisRacer.Name = racer;
                thisRacer.Fuel = racer[0];

                for (int i = 0; i < track.Count; i++)
                {
                    if (isCheckPoint[i])
                    {
                        thisRacer.Fuel += track[i];
                    }
                    else
                    {
                        thisRacer.Fuel -= track[i];

                        if (thisRacer.Fuel <= 0)
                        {
                            thisRacer.ReachedIndex = i;
                            break;
                        }
                    }
                }
                allRacers.Add(thisRacer);
            }

            foreach (var racer in allRacers)
            {
                if (racer.Fuel > 0.0)
                    Console.WriteLine($"{racer.Name} - fuel left {racer.Fuel:f2}");

                else
                    Console.WriteLine($"{racer.Name} - reached {racer.ReachedIndex}");
            }
        }
    }
}
