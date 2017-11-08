using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sumLeft = 0;
            int sumRight = 0;
            bool checker = true;

            if (numbers.Length <= 1)
            {
                checker = false;
                Console.WriteLine(0);
            }
            else
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        sumLeft += numbers[j];
                    }
                    for (int k = i + 1; k < numbers.Length; k++)
                    {
                        sumRight += numbers[k];
                    }

                    if (sumLeft == sumRight)
                    {
                        checker = false;
                        Console.WriteLine(i);
                        break;
                    }

                    sumLeft = 0;
                    sumRight = 0;
                }
            }
            if (checker)
            {
                Console.WriteLine("no");
            }
        }
    }
}
