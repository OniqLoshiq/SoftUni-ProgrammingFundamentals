using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_SrabskoUnleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var folkersData = new Dictionary<string, Dictionary<string, long>>();

            GetFolkersData(folkersData, input);

            foreach (var venue in folkersData)
            {
                Console.WriteLine($"{venue.Key}");

                foreach (var singer in venue.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine("#  {0} -> {1}", singer.Key, singer.Value);
                }
            }
        }

        private static void GetFolkersData(Dictionary<string, Dictionary<string, long>> folkersData, string input)
        {
            while (input != "End")
            {
                if (input.Split().Length >= 4)
                {
                    if (input.Split().Count((x) => x.StartsWith("@")) >= 1)
                    {
                        string[] singerName = input.Split('@');
                        int index = input.IndexOf('@');

                        if (input[0] == '@') //kapav kod
                        {
                            index = input.IndexOf('@', input.IndexOf('@') + 1);
                        }

                        List<string> venueAndTickets = input.Remove(0, index).Split().ToList();


                        if (venueAndTickets.Count >= 3)
                        {
                            string singer = input.Remove(index - 1);
                            List<string> checkerSingerName = singer.Split().ToList();

                            if (checkerSingerName.Count <= 3)
                            {
                                if (long.TryParse(venueAndTickets[venueAndTickets.Count - 1], out _)
                                       && long.TryParse(venueAndTickets[venueAndTickets.Count - 2], out _))
                                {
                                    long ticketCount = long.Parse(venueAndTickets[venueAndTickets.Count - 1]);
                                    venueAndTickets.RemoveAt(venueAndTickets.Count - 1);

                                    long ticketPrice = long.Parse(venueAndTickets[venueAndTickets.Count - 1]);
                                    venueAndTickets.RemoveAt(venueAndTickets.Count - 1);

                                    long ticketMoney = ticketCount * ticketPrice;
                                    string venue = string.Join(" ", venueAndTickets);
                                    venue = venue.TrimStart('@');

                                    List<string> checkerVenueName = venue.Split().ToList();

                                    if (checkerVenueName.Count <= 3)
                                    {
                                        if (!folkersData.ContainsKey(venue))
                                        {
                                            folkersData[venue] = new Dictionary<string, long>();
                                        }
                                        if (!folkersData[venue].ContainsKey(singer))
                                        {
                                            folkersData[venue][singer] = ticketMoney;
                                        }
                                        else
                                        {
                                            folkersData[venue][singer] += ticketMoney;
                                        }
                                    }
                                }

                            }
                        }
                    }
                }
                input = Console.ReadLine();
            }
        }
    }
}
