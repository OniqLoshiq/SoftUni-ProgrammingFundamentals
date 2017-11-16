using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04_RoliTheCoder
{
    class Event
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public HashSet<string> Participants { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var allIDs = new List<Event>();

            while (true)
            {
                string inputData = Console.ReadLine();
                if (inputData == "Time for Code") break;
                if (!inputData.Contains("#")) continue;

                if (!Regex.IsMatch(inputData, @"^[0-9]+\s+#")) continue;

                string[] dataValues = inputData.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                int ID = int.Parse(dataValues[0]);
                string eventName = dataValues[1].TrimStart('#');

                MatchCollection matchParticipants = Regex.Matches(inputData, @"((?<=@)[a-zA-Z\-\'0-9]+)");
                List<string> participants = matchParticipants.Cast<Match>().Select(x => x.Value).ToList();

                if (!allIDs.Any(x => x.ID == ID))
                {
                    Event currentID = new Event()
                    {
                        ID = ID,
                        Name = eventName,
                        Participants = new HashSet<string>(participants)
                    };

                    allIDs.Add(currentID);
                }
                else
                {
                    Event currentID = allIDs.FirstOrDefault(x => x.ID == ID);
                    if (currentID.Name == eventName)
                    {
                        currentID.Participants.UnionWith(participants);
                    }
                }
            }

            foreach (var id in allIDs.OrderByDescending(x => x.Participants.Count).ThenBy(x => x.Name))
            {
                Console.WriteLine($"{id.Name} - {id.Participants.Count}");

                foreach (var person in id.Participants.OrderBy(x => x))
                {
                    Console.WriteLine($"@{person}");
                }
            }
        }
    }
}
