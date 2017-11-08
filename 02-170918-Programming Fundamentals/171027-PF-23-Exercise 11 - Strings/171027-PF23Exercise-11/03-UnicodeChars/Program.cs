using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_UnicodeChars
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] text = Console.ReadLine().ToArray();

            StringBuilder unicodePrint = new StringBuilder();

            foreach (var item in text)
            {
                unicodePrint.Append($"\\u{((int)item).ToString("x4")}");
            }

            Console.WriteLine(unicodePrint);
        }
    }
}
