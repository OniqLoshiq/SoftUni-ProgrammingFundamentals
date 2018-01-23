using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01_Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int balls = int.Parse(Console.ReadLine());

            BigInteger maxValue = new BigInteger();
            int maxSnow = 0;
            int maxTime = 0;
            int maxQuality = 0;

            for (int i = 0; i < balls; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());

                BigInteger thisValue = new BigInteger();

                thisValue = BigInteger.Pow(((BigInteger)snow / time), quality);

                if (thisValue > maxValue)
                {
                    maxValue = thisValue;
                    maxSnow = snow;
                    maxTime = time;
                    maxQuality = quality;
                }

            }

            Console.WriteLine("{0} : {1} = {2} ({3})", maxSnow, maxTime, maxValue, maxQuality);
        }
    }
}
