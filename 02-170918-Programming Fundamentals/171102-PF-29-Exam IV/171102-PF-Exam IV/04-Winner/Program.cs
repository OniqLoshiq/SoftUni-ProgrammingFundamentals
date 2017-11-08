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
            string inputTickets = Console.ReadLine();

            List<string> allTickets = inputTickets.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            foreach (var ticket in allTickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
                Regex isValidTickets = new Regex(@"([\$#@^]{6,10}?)(.*?)\1");

                Match ticketGroups = isValidTickets.Match(ticket);
                string leftRightSide = ticketGroups.Groups[1].Value;

                char[] chars = leftRightSide.ToCharArray().Distinct().ToArray();


                if (!isValidTickets.IsMatch(ticket) || chars.Length > 1)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }
                else
                {
                    if (leftRightSide.Length == 10)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - 10{leftRightSide[0]} Jackpot!");
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - {leftRightSide.Length}{leftRightSide[0]}");
                    }
                }

            }


        }
    }
}
