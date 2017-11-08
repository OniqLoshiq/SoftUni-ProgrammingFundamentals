using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_MostFreqNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int counter = 1;
            int bestCounter = 1;
            int number = 0;
            int bestNum = 0;
            bool[] isEqual = new bool[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                isEqual[i] = false;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (isEqual[i] == false)
                {
                    for (int j = 0; j < numbers.Length; j++)
                    {
                        if (numbers[i] == numbers[j])
                        {
                            counter++;
                            isEqual[j] = true;
                            number = i;
                            if (bestCounter < counter)
                            {
                                bestCounter = counter;
                                bestNum = i;
                            }
                            else if (bestCounter == counter)
                            {
                                bestNum = Math.Min(bestNum, number);
                            }
                        }
                    }
                }
                counter = 1;
            }

            Console.WriteLine(numbers[bestNum]);
        }
    }
}
