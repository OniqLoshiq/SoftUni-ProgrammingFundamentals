using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03_NetherRealms
{
    class Demon
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public double Damage { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] inputData = Console.ReadLine().Split(new[] { ',', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            List<Demon> allDemons = new List<Demon>();

            for (int i = 0; i < inputData.Length; i++)
            {
                if (Regex.IsMatch(inputData[i], @"[^\+\/\.\-\*0-9]"))
                {
                    Demon currentDemon = new Demon();

                    currentDemon.Name = inputData[i];

                    string patternHlth = @"[^\+\/\.\-\*0-9]+";
                    MatchCollection matchesHlth = Regex.Matches(inputData[i], patternHlth);
                    StringBuilder sb = new StringBuilder();
                    foreach (Match item in matchesHlth)
                    {
                        sb.Append(item);
                    }
                    int sumHealth = sb.ToString().Select(y => (int)(Convert.ToChar(y))).Sum();
                    currentDemon.Health = sumHealth;

                    string patternDmg = @"((\+|\-)*(([0-9]+\.)?[0-9]+))";
                    MatchCollection matchesDmg = Regex.Matches(inputData[i], patternDmg);
                    double sumNums = matchesDmg.Cast<Match>().Select(x => double.Parse(x.Value)).Sum();

                    string patternDmgCmd = @"[\*\/]";
                    MatchCollection matchesCmd = Regex.Matches(inputData[i], patternDmgCmd);
                    foreach (Match cmd in matchesCmd)
                    {
                        if (cmd.Value == "*")
                        {
                            sumNums *= 2.0;
                        }
                        else
                        {
                            sumNums /= 2.0;
                        }
                    }
                    currentDemon.Damage = sumNums;

                    allDemons.Add(currentDemon);
                }
            }
            foreach (var demon in allDemons.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:f2} damage");
            }
        }
    }
}
