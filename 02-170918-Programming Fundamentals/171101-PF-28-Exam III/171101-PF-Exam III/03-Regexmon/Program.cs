using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            string patternDidi = @"[^a-zA-Z\-]+";
            string patternBojo = @"[A-Za-z]+\-[A-Za-z]+";

            while (inputText.Length != 0)
            {
                Match didiMatch = Regex.Match(inputText, patternDidi);

                string didiToPrint = String.Empty;

                if (didiMatch.Success)
                {
                    didiToPrint = didiMatch.ToString();
                    Console.WriteLine(didiToPrint);
                }
                else
                {
                    break;
                }

                int indexDidi = inputText.IndexOf(didiToPrint);

                inputText = inputText.Substring(indexDidi + didiToPrint.Length);

                Match bojoMatch = Regex.Match(inputText, patternBojo);

                string bojoToPrint = String.Empty;

                if (bojoMatch.Success)
                {
                    bojoToPrint = bojoMatch.ToString();
                    Console.WriteLine(bojoToPrint);
                }
                else
                {
                    break;
                }

                int indexBojo = inputText.IndexOf(bojoToPrint);

                inputText = inputText.Substring(indexBojo + bojoToPrint.Length);
            }
        }
    }
}
