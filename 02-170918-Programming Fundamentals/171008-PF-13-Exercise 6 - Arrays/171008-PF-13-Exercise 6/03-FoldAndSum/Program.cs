using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] firstRow = FirstRow(numbers);
            int[] secondRow = new int[numbers.Length / 2];
            int[] sumRows = new int[numbers.Length / 2];

            for (int i = 0; i < numbers.Length / 2; i++)
            {
                secondRow[i] = numbers[numbers.Length / 4 + i];

                sumRows[i] = firstRow[i] + secondRow[i];
            }

            Console.WriteLine(string.Join(" ", sumRows));
        }

        static int[] FirstRow(int[] numbers)
        {
            int[] firstRow = new int[numbers.Length / 2];

            for (int i = 0; i < firstRow.Length / 2; i++)
            {
                firstRow[i] = numbers[numbers.Length / 4 - 1 - i];
            }
            for (int i = 0; i < firstRow.Length / 2; i++)
            {
                firstRow[numbers.Length / 4 + i] = numbers[numbers.Length - 1 - i];
            }

            return firstRow;
        }
    }
}
