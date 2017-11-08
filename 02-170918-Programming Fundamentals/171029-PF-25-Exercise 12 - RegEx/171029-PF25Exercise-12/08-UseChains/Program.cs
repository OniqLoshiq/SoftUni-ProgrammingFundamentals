using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08_UseChains
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));

            string inputText = Console.ReadLine();

            string pattern = @"<p>(.+?)<\/p>";
            MatchCollection validString = Regex.Matches(inputText, pattern);
            StringBuilder sb = new StringBuilder();
            foreach (Match item in validString)
            {
                string textToAppend = item.Groups[1].Value;
                sb.Append(textToAppend);
            }

            string validText =  sb.ToString();
            validText = Regex.Replace(validText, @"[^a-z0-9]+", " ");
            validText = Regex.Replace(validText, @"\s+", " ");

            List<string> validWords = validText.Split().ToList();

            char[] alphabeth = new char[26];
            for (int i = 0; i < alphabeth.Length; i++)
            {
                alphabeth[i] = (char)('a' + i);
            }

            char[] convertedAlphabeth = new char[26];
            for (int i = 0; i < 13; i++)
            {
                convertedAlphabeth[i] = alphabeth[13 + i];
                convertedAlphabeth[13 + i] = alphabeth[i];
            }

            List<string> output = new List<string>();

            foreach (var word in validWords)
            {
                if (!Int32.TryParse(word, out _))
                {
                    char[] wordChars = new char[word.Length];
                    for (int i = 0; i < wordChars.Length; i++)
                    {
                        wordChars[i] = convertedAlphabeth[Array.IndexOf(alphabeth, word[i])];
                    }
                    output.Add(new string(wordChars));
                }
                else
                {
                    output.Add(word);
                }
            }
            Console.WriteLine(string.Join(" ", output));
        }
    }
}
