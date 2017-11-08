using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07_QueryMess
{
    class Program
    {
        // 90 ot 100
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            var pairs = new Dictionary<int, Dictionary<string, List<string>>>();
            int inputCounter = 0;

            string pattern = @"(^[\w]+=((.*?)((?=\&)|$)))|(((?<=\?)|(?<=&)))(.*?)=(.*?)((?=&)|$)";

            while (inputLine != "END")
            {
                inputLine = Regex.Replace(inputLine, @"(%20)|\+", " ");
                inputLine = Regex.Replace(inputLine, @"\s{2,}", " ");

                MatchCollection validPairs = Regex.Matches(inputLine, pattern);
                inputCounter++;
                foreach (Match pair in validPairs)
                {
                    string[] clearPair = pair.Value.Split('=').Select(x => x.Trim()).ToArray();
                    string keyPair = clearPair[0];
                    string valuePair = clearPair[1];

                    if (!pairs.ContainsKey(inputCounter))
                    {
                        pairs[inputCounter] = new Dictionary<string, List<string>>();
                    }
                    if (!pairs[inputCounter].ContainsKey(keyPair))
                    {
                        pairs[inputCounter][keyPair] = new List<string>();
                    }
                    pairs[inputCounter][keyPair].Add(valuePair);
                }

                inputLine = Console.ReadLine();
            }

            foreach (var pairvalue in pairs)
            {
                foreach (var item in pairvalue.Value)
                {
                    Console.Write("{0}=[{1}]", item.Key, string.Join(", ", item.Value));
                }
                Console.WriteLine();
            }
        }
    }
}
