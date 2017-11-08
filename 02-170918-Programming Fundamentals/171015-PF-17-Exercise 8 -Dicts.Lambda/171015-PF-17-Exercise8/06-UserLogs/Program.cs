using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> flooders = new SortedDictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputLine = input.Split().ToArray();
                string ip = inputLine[0].Substring(3);
                string username = inputLine[2].Substring(5);

                if (!flooders.ContainsKey(username))
                {
                    flooders[username] = new Dictionary<string, int>();
                }
                if (!flooders[username].ContainsKey(ip))
                {
                    flooders[username][ip] = 1;
                }
                else
                {
                    flooders[username][ip] += 1;
                }

                input = Console.ReadLine();
            }

            foreach (var flooder in flooders)
            {
                string username = flooder.Key;
                var ips = flooder.Value;

                Console.WriteLine($"{username}:");
                string print = "";
                foreach (var ip in ips)
                {
                    print += ip.Key + " => " + ip.Value + ", ";
                }

                Console.WriteLine(print.Remove(print.Length - 2) + ".");
            }
        }
    }
}
