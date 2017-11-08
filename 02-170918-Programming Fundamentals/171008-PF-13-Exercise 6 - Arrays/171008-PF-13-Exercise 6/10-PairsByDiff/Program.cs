using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_PairsByDiff
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int diff = int.Parse(Console.ReadLine());

            int diffNegative = diff * (-1);
            int counter = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i; j < numbers.Length - 1; j++)
                {
                    int numDiff = numbers[i] - numbers[j + 1];
                    if (numDiff == diff || numDiff == diffNegative)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
