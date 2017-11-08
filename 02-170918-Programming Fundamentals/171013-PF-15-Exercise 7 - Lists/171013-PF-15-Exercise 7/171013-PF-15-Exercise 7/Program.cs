using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _171013_PF_15_Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int start = 0;
            int bestStart = 0;
            int counter = 1;
            int bestCounter = 1;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    counter++;

                    if (bestCounter < counter)
                    {
                        bestCounter = counter;
                        bestStart = start;
                    }
                }
                else
                {
                    counter = 1;
                    start = i;
                }
            }
            if (bestCounter == counter)
            {
                bestStart = Math.Min(bestStart, start);
            }

            List<int> maxSeq = new List<int>();

            for (int i = 0; i < bestCounter; i++)
            {
                maxSeq.Add(numbers[bestStart + i]);
            }

            Console.WriteLine(string.Join(" ", maxSeq));
        }
    }
}
