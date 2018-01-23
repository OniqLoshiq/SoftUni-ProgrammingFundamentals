using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03_Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int coreLenght = 0;

            Regex patternSurface = new Regex(@"^[^A-Za-z0-9]+$");
            Regex patternMantle = new Regex(@"^[\d_]+$");
            Regex patternCore = new Regex(@"^([^A-Za-z0-9]+)([0-9_]+)([A-Za-z]+)([0-9_]+)([^A-Za-z0-9]+)$");

            for (int i = 0; i < 5; i++)
            {
                string input = Console.ReadLine();

                if (i == 0 || i == 4)
                {
                    if (patternSurface.IsMatch(input))
                    {
                        counter++;
                    }
                }
                else if (i == 1 || i == 3)
                {
                    if (patternMantle.IsMatch(input))
                    {
                        counter++;
                    }
                }
                else
                {
                    if (patternCore.IsMatch(input))
                    {
                        counter++;
                        Match match = patternCore.Match(input);
                        coreLenght = match.Groups[3].Length;
                    }
                }
            }

            if (counter == 5)
            {
                Console.WriteLine("Valid" + Environment.NewLine + coreLenght);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
