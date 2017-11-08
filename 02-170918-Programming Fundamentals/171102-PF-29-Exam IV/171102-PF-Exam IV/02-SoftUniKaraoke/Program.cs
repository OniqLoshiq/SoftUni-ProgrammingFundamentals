using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_SoftUniKaraoke
{
    class Program
    {
        static void Main(string[] args)
        {
            var allSingers = new Dictionary<string, Dictionary<string, string>>();

            List<string> singers = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> songs = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            while (true)
            {
                string[] inputInfo = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (inputInfo[0] == "dawn")
                {
                    break;
                }

                string singer = inputInfo[0];
                string song = inputInfo[1];
                string award = inputInfo[2];

                if (!singers.Contains(singer) || !songs.Contains(song))
                    continue;

                if (!allSingers.ContainsKey(singer))
                    allSingers[singer] = new Dictionary<string, string>();

                if (!allSingers[singer].ContainsKey(award))
                    allSingers[singer][award] = song;
            }

            if (allSingers.Count == 0)
                Console.WriteLine("No awards");
            else
            {
                foreach (var singer in allSingers.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{singer.Key}: {singer.Value.Count} awards");
                    foreach (var award in singer.Value.OrderBy(x => x.Key))
                    {
                        Console.WriteLine($"--{award.Key}");
                    }
                }
            }
        }
    }
}
