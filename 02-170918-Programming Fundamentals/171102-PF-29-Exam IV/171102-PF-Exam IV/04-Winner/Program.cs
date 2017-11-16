using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04_Winner
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> tickets = Console.ReadLine().Split(new[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string validPattern = @"[@#\$\^]";

            for (int i = 0; i < tickets.Count; i++)
            {
                if (tickets[i].Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else if (!Regex.IsMatch(tickets[i], validPattern))
                {
                    Console.WriteLine($"ticket \"{tickets[i]}\" - no match");
                }
                else if (tickets[i].Distinct().Count() == 1)
                {
                    Console.WriteLine($"ticket \"{tickets[i]}\" - 10{tickets[i][0]} Jackpot!");
                }
                else
                {
                    string leftSide = new string(tickets[i].Take(10).ToArray());
                    string rightSide = new string(tickets[i].Skip(10).ToArray());
                    string pattern = @"(@{6,10}|#{6,10}|\${6,10}|\^{6,10})";
                    Match matchLeft = Regex.Match(leftSide, pattern);
                    Match matchRight = Regex.Match(rightSide, pattern);

                    if (matchLeft.Success && matchRight.Success)
                    {
                        string match = matchRight.ToString();
                        if (matchRight.Length == matchLeft.Length && matchLeft.ToString()[0] == matchRight.ToString()[0])
                        {
                            Console.WriteLine($"ticket \"{tickets[i]}\" - {match.Length}{match[0]}");
                        }
                        else if (matchLeft.ToString()[0] == matchRight.ToString()[0])
                        {
                            if (matchLeft.Length < matchRight.Length)
                            {
                                match = matchLeft.ToString();
                            }
                            Console.WriteLine($"ticket \"{tickets[i]}\" - {match.Length}{match[0]}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{tickets[i]}\" - no match");
                    }
                }
            }
        }
    }
}
