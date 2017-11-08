using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bombNums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (numbers.Contains(bombNums[0]))
            {
                int index = numbers.IndexOf(bombNums[0]);
                numbers.RemoveAt(index);
                for (int i = 0; i < bombNums[1]; i++)
                {
                    if (index - 1 >= 0)
                    {
                        numbers.RemoveAt(index - 1);
                    }

                    if (index - 1 < 0) index = 0;
                    else index--;

                    if (index < numbers.Count)
                    {
                        numbers.RemoveAt(index);
                    }
                }
            }

            Console.WriteLine(numbers.Sum());

        }
    }
}
