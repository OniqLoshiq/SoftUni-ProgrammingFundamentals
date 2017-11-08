using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_LongAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var userInfo = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                string user = input[1];
                string ip = input[0];
                int duration = int.Parse(input[2]);

                if (!userInfo.ContainsKey(user))
                {
                    userInfo[user] = new Dictionary<string, int>();
                }
                if (!userInfo[user].ContainsKey(ip))
                {
                    userInfo[user][ip] = duration;
                }
                else
                {
                    userInfo[user][ip] += duration;
                }
            }

            foreach (var user in userInfo.OrderBy(x => x.Key))
            {
                List<string> myIPs = user.Value.Keys.ToList();

                Console.Write("{0}: {1} [{2}]",
                    user.Key, user.Value.Sum(x => x.Value), string.Join(", ", myIPs.OrderBy(x => x)));

                Console.WriteLine();
            }
        }
    }
}
