using System;
using System.Collections.Generic;
using System.Linq;

namespace _09_TeamworkProjects
{
    class Teams
    {
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Teams> allTeams = new List<Teams>();
            
            for (int i = 0; i < n; i++)
            {
                string[] inputLine = Console.ReadLine().Split('-');
                Teams team = new Teams();

                team.Creator = inputLine[0];
                team.Name = inputLine[1];

                if (!allTeams.Any(x => x.Name == team.Name) && !allTeams.Any(x => x.Creator == team.Creator))
                {
                    allTeams.Add(team);
                    team.Members = new List<string>();
                    Console.WriteLine("Team {0} has been created by {1}!", team.Name, team.Creator);
                }
                else if (allTeams.Any(x => x.Name == team.Name))
                {
                    Console.WriteLine("Team {0} was already created!", team.Name);
                }
                else
                {
                    Console.WriteLine("{0} cannot create another team!", team.Creator);
                }
            }

            string inputMembers = Console.ReadLine();

            while (inputMembers != "end of assignment")
            {
                string[] membersLine = inputMembers.Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries);

                Teams team = new Teams();
                
                team.Name = membersLine[1];

                if (!allTeams.Any(x => x.Creator == membersLine[0]) && allTeams.Any(x => x.Name == team.Name) && !allTeams.Any(x => x.Members.Contains(membersLine[0])))
                {
                    allTeams[allTeams.FindIndex(x => x.Name == team.Name)].Members.Add(membersLine[0]);
                }
                else if (!allTeams.Any(x => x.Name == team.Name))
                {
                    Console.WriteLine($"Team {team.Name} does not exist!");
                }
                else if (allTeams.Any(x => x.Creator == membersLine[0]) || allTeams.Any(x => x.Members.Contains(membersLine[0])))
                {
                    Console.WriteLine($"Member {membersLine[0]} cannot join team {team.Name}!");
                }
                
                inputMembers = Console.ReadLine();
            }

            List<Teams> teamsToForm = allTeams.Where(x => x.Members.Count > 0).OrderByDescending(x => x.Members.Count).ThenBy(x => x.Name).ToList();
            List<Teams> teamsToDelete = allTeams.Where(x => x.Members.Count == 0).OrderBy(x => x.Name).ToList();
           
            foreach (var team in teamsToForm)
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.Creator}");

                foreach (var member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var team in teamsToDelete)
            {
                Console.WriteLine($"{team.Name}");
            }
        }
    }
}
