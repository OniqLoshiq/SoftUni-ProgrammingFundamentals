using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06_ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            string pattern = @"\b[a-zA-Z]([a-zA-Z0-9_]){2,24}\b";

            MatchCollection validUsernames = Regex.Matches(inputText, pattern);

            List<string> usernames = validUsernames.Cast<Match>().Select(x => x.Value).ToList();

            int bestSumLengths = 0;
            int firstIndex = 0;

            for (int i = 0; i < usernames.Count - 1; i++)
            {
                int sumLengths = usernames[i].Length + usernames[i + 1].Length;
                if (sumLengths > bestSumLengths)
                {
                    bestSumLengths = sumLengths;
                    firstIndex = i;
                }
            }

            Console.WriteLine(usernames[firstIndex]);
            Console.WriteLine(usernames[firstIndex + 1]);
        }
    }
}
