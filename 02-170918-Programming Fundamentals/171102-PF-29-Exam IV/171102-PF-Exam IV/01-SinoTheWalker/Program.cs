using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01_SinoTheWalker
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] timeNow = Console.ReadLine().Split(':').Select(int.Parse).ToArray();
            int steps = int.Parse(Console.ReadLine()) % 86400;
            int secsPerStep = int.Parse(Console.ReadLine()) % 86400;

            BigInteger totalSecs = new BigInteger();

            totalSecs = ((BigInteger)steps * secsPerStep) + timeNow[0] * 3600 + timeNow[1] * 60 + timeNow[2];

            TimeSpan time = TimeSpan.FromSeconds((double)totalSecs);
           
            string timeToPrint = time.ToString(@"hh\:mm\:ss", CultureInfo.InvariantCulture);

            Console.WriteLine($"Time Arrival: {timeToPrint}");

        }
    }
}
