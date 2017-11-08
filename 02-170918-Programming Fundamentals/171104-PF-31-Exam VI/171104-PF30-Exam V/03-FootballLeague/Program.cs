using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03_FootballLeague
{
    class Team
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public long Goals { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            List<Team> allTeams = new List<Team>();

            while (true)
            {
                string inputLine = Console.ReadLine();
                string[] resultInfo = inputLine.Split().ToArray();
                if (inputLine == "final")
                {
                    break;
                }
                long[] goals = resultInfo[2].Split(':').Select(long.Parse).ToArray();
                long goalsTeamA = goals[0];
                long goalsTeamB = goals[1];

                string keyEscape = Regex.Escape($@"{key}");
                string teamsReg = $@"({keyEscape})(.*?)\1";
                MatchCollection teams = Regex.Matches(inputLine, teamsReg);

                Team TeamA = new Team();
                Team TeamB = new Team();

                char[] reversedTeamA = teams[0].Groups[2].Value.ToCharArray();
                char[] reversedTeamB = teams[1].Groups[2].Value.ToCharArray();
                Array.Reverse(reversedTeamA);
                Array.Reverse(reversedTeamB);

                TeamA.Name = new string(reversedTeamA).ToUpper();
                TeamB.Name = new string(reversedTeamB).ToUpper();
               
                TeamA.Goals = goalsTeamA;
                TeamB.Goals = goalsTeamB;

                if (goalsTeamA > goalsTeamB)
                {
                    TeamA.Points = 3;
                }
                else if (goalsTeamA < goalsTeamB)
                {
                    TeamB.Points = 3;
                }
                else
                {
                    TeamA.Points = 1;
                    TeamB.Points = 1;
                }

                if (!allTeams.Any(x => x.Name == TeamA.Name))
                {
                    Team currentTeamA = TeamA;
                    allTeams.Add(currentTeamA);
                }
                else
                {
                    Team currentTeamA = allTeams.FirstOrDefault(z => z.Name == TeamA.Name);
                    currentTeamA.Goals += TeamA.Goals;
                    currentTeamA.Points += TeamA.Points;
                }

                if (!allTeams.Any(x => x.Name == TeamB.Name))
                {
                    Team currentTeamB = TeamB;
                    allTeams.Add(currentTeamB);
                }
                else
                {
                    Team currentTeamB = allTeams.FirstOrDefault(z => z.Name == TeamB.Name);
                    currentTeamB.Goals += TeamB.Goals;
                    currentTeamB.Points += TeamB.Points;
                }
            }

            Console.WriteLine("League standings:");
            int counterPosition = 1;
            foreach (var team in allTeams.OrderByDescending(z => z.Points))
            {
                Console.WriteLine($"{counterPosition}. {team.Name} {team.Points}");
                counterPosition++;
            }

            Console.WriteLine("Top 3 scored goals:");
            int counterGoals = 0;
            foreach (var team in allTeams.OrderByDescending(z => z.Goals).ThenBy(z => z.Name))
            {
                if (counterGoals == 3)
                {
                    break;
                }
                Console.WriteLine($"- {team.Name} -> {team.Goals}");
                counterGoals++;

            }
        }
    }
}
