using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01_DownSite
{
    class Program
    {
        static void Main(string[] args)
        {
            int countDownSites = int.Parse(Console.ReadLine());
            int securityKEy = int.Parse(Console.ReadLine());

            List<string> allSites = new List<string>();
            decimal totalLoss = 0.0M;

            for (int i = 0; i < countDownSites; i++)
            {
                string[] inputData = Console.ReadLine().Split();
                string site = inputData[0];
                allSites.Add(site);
                decimal siteVisits = decimal.Parse(inputData[1]);
                decimal pricePerVisit = decimal.Parse(inputData[2]);

                decimal siteLoss = siteVisits * pricePerVisit;

                totalLoss += siteLoss;
            }
            BigInteger token = new BigInteger();
            token = 1;
            for (int i = 0; i < countDownSites; i++)
            {
                token *=  securityKEy;
            }

            Console.WriteLine(string.Join(Environment.NewLine, allSites));
            Console.WriteLine($"Total Loss: {totalLoss:f20}");
            Console.WriteLine("Security Token: {0}", token);
        }
    }
}
