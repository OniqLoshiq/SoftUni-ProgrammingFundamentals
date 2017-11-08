using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] word = Console.ReadLine().ToLower().ToArray();

            char[] alphabeth = new char[26];

            for (int i = 0; i < 26; i++)
            {
                alphabeth[i] = (char)('a' + i);
            }

            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine("{0} -> {1}", word[i], Array.IndexOf(alphabeth, word[i]));
            }
        }
    }
}
