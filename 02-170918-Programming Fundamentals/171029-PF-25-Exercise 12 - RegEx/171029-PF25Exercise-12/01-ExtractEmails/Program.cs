using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01_ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"(^|(?<=\s))[a-zA-Z][\w-.]+@[a-z]+[a-z\-\.]+\.[a-z]+";

            MatchCollection validEmails = Regex.Matches(text, pattern);

            foreach (Match email in validEmails)
            {
                Console.WriteLine(email.Value);
            }
        }
    }
}
