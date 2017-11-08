using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_HornetWings
{
    class Program
    {
        static void Main(string[] args)
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            double distancePer1kFlaps = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());

            double distancePassed = (wingFlaps / 1000.0) * distancePer1kFlaps;
            int metersTraveled = (wingFlaps / 100) + (wingFlaps / endurance) * 5;

            Console.WriteLine($"{distancePassed:f2} m.");
            Console.WriteLine($"{metersTraveled} s.");
        }
    }
}
