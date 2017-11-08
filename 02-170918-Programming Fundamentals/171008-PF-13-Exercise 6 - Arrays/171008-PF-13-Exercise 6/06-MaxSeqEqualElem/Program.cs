using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_MaxSeqEqualElem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int counter = 1;
            int bestCounter = 1;
            int start = 0;
            int bestStart = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    counter++;
                                                            
                    if (bestCounter < counter)
                    {
                        bestCounter = counter;
                        bestStart = start;
                    }
                    else if (bestCounter == counter)
                    {
                        bestStart = Math.Min(bestStart, start);
                    }
                }
                else
                {
                    counter = 1;
                    start = i;
                }
            }
            int[] maxSeq = new int[bestCounter];

            for (int i = 0; i < bestCounter; i++)
            {
                maxSeq[i] = numbers[bestStart + i];
            }

            Console.WriteLine(string.Join(" ",maxSeq));
        }
    }
}
