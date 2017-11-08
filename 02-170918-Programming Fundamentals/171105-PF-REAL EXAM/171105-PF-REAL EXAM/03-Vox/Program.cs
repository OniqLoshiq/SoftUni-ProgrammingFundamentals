using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03_Vox
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string placeholders = Console.ReadLine();

            Regex regText = new Regex(@"([a-zA-Z]+)(.*)(\1)");
            Regex regPlacehldrs = new Regex(@"\{(.*?)\}");

            List<string> allPlacehldrs = regPlacehldrs.Matches(placeholders).Cast<Match>().Select(x => x.Groups[1].Value).ToList();

            int counter = 0;
            //
            //text = Regex.Replace(text, @"([a-zA-Z]+)(.*)(\1)", m => m.Groups[1].Value + allPlacehldrs[counter++] + m.Groups[3].Value);
            //
            //Console.WriteLine(text);

            MatchCollection matches = regText.Matches(text);
            List<string> allPlacehldrsInText = matches.Cast<Match>().Select(x => x.Groups[2].Value).ToList();

            foreach (Match match in matches)
            {
                if (counter >= allPlacehldrs.Count || counter >= allPlacehldrsInText.Count)
                {
                    break;
                }
                StringBuilder sb = new StringBuilder();
                int index = text.IndexOf(allPlacehldrsInText[counter]);

                sb.Append(text.Substring(0, index));
                sb.Append(allPlacehldrs[counter]);
                sb.Append(text.Substring(index + allPlacehldrsInText[counter].Length));

                counter++;
                text = sb.ToString();
            }
            Console.WriteLine(text);

        }
    }
}
