using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02_ExtractSentByKeyWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string[] text = Console.ReadLine().Split(new char[] { '.','!','?'}, StringSplitOptions.RemoveEmptyEntries);

            string pattern = "\\b" + word + "\\b";
            
            foreach (var sentance in text)
            {
                if(Regex.IsMatch(sentance, pattern))
                {
                    Console.WriteLine(sentance.Trim());
                }
            }
        }
    }
}
