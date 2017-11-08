using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            float distanceMeters = float.Parse(Console.ReadLine());
            byte hours = byte.Parse(Console.ReadLine());
            byte minutes = byte.Parse(Console.ReadLine());
            byte seconds = byte.Parse(Console.ReadLine());

            int totalSeconds = seconds + (minutes * 60) + (hours * 3600);
            float totalHours = hours + (minutes / 60F) + (seconds / 3600F);

            float speedMeter = distanceMeters / totalSeconds;
            float speedKm = distanceMeters / 1000F / totalHours;
            float speedMile = (distanceMeters / 1609f / totalHours);

            Console.WriteLine(speedMeter);
            Console.WriteLine(speedKm);
            Console.WriteLine(speedMile);
        }
    }
}
