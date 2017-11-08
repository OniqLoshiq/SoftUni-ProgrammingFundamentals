using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CharityMarathon
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            long runners = long.Parse(Console.ReadLine());
            int avgLapsPerRunner = int.Parse(Console.ReadLine());
            int trackLengthMeters = int.Parse(Console.ReadLine());
            int trackCapacity = int.Parse(Console.ReadLine());
            double moneyPerKm = double.Parse(Console.ReadLine());

            if ((trackCapacity * days) < runners)
                runners = trackCapacity * days;

            double totalKms = runners * avgLapsPerRunner * (trackLengthMeters / 1000.0);
            decimal raisedMoney = (decimal)totalKms * (decimal)moneyPerKm;

            Console.WriteLine($"Money raised: {raisedMoney:f2}");

        }
    }
}
