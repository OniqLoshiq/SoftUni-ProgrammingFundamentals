using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_CharMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            string first = input[0];
            string second = input[1];

            string shorterWord = String.Empty;
            string longerWord = String.Empty;

            if (first.Length >= second.Length)
            {
                longerWord = first;
                shorterWord = second;
            }
            else
            {
                longerWord = second;
                shorterWord = first;
            }

            long sum = 0L;

            for (int i = 0; i < longerWord.Length; i++)
            {
                if (shorterWord.Length > i)
                {
                    sum += longerWord[i] * shorterWord[i];
                }
                else
                {
                     sum += longerWord[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
