using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_MagicExchWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string firstWord = input[0];
            string secondWord = input[1];

            string firstUnique = String.Empty;
            string secondUnique = String.Empty;

            firstUnique = new string(firstWord.Distinct().ToArray());
            secondUnique = new string(secondWord.Distinct().ToArray());

            //for (int i = 0; i < firstWord.Length; i++)
            //{
            //    if (!firstUnique.Contains(firstWord[i])) firstUnique += firstWord[i];
            //
            //}
            //for (int i = 0; i < secondWord.Length; i++)
            //{
            //    if (!secondUnique.Contains(secondWord[i])) secondUnique += secondWord[i];
            //}

            string isMagic = "false";

            if (firstUnique.Length == secondUnique.Length) isMagic = "true";

            Console.WriteLine(isMagic);

        }
    }
}
