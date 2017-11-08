using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_MelrahShake
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = Console.ReadLine();

            if (text.IndexOf(pattern) != text.LastIndexOf(pattern))
            {
                while (true)
                {
                    if (text.IndexOf(pattern) > -1 && text.LastIndexOf(pattern) > -1 && pattern.Length > 0)
                    {
                        int firstIndex = text.IndexOf(pattern);
                        text = text.Remove(firstIndex, pattern.Length);

                        int lastIndex = text.LastIndexOf(pattern);
                        text = text.Remove(lastIndex, pattern.Length);

                        Console.WriteLine("Shaked it.");
                    }
                    else
                    {
                        break;
                    }

                    if (pattern.Length > 0)
                    {
                        pattern = pattern.Remove(pattern.Length / 2, 1);
                    }
                }
            }
            Console.WriteLine("No shake.");
            Console.WriteLine(text);
        }
    }
}
