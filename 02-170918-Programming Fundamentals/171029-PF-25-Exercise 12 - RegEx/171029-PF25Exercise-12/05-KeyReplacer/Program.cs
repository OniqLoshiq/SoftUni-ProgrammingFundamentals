using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05_KeyReplacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string text = Console.ReadLine();

            string keyPattern = @"([a-zA-Z]+?)([<\\\|]).*([<\\\|])([a-zA-z]+)";
            Match keyStartEnd = Regex.Match(key, keyPattern);
            string keyStart = keyStartEnd.Groups[1].Value;
            string keyEnd = keyStartEnd.Groups[4].Value;

            string textPattern = $@"(?<={keyStart}).*?(?={keyEnd})";
            MatchCollection validString = Regex.Matches(text, textPattern);
            
            StringBuilder outputString = new StringBuilder();

            foreach (Match item in validString)
            {
                outputString.Append(item.Value.Trim());
            }
            if (outputString.Length != 0)
            {
                Console.WriteLine(outputString);
            }

            else
            {
                Console.WriteLine("Empty result");
            }

        }
    }
}
