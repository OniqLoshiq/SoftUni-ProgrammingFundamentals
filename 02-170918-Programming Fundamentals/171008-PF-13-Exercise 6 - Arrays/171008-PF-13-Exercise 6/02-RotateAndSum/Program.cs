using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int indexRotate = int.Parse(Console.ReadLine());

            int[] sumNums = new int[numbers.Length];

            for (int i = 0; i < indexRotate; i++)
            {
                int[] reversedArr = new int[numbers.Length];

                for (int j = 0; j < numbers.Length; j++)
                {
                    reversedArr[(j + 1) % reversedArr.Length] = numbers[j];

                    sumNums[(j + 1) % reversedArr.Length] += numbers[j];
                }
                numbers = reversedArr;
            }

            Console.WriteLine(string.Join(" ", sumNums));
        }
    }
}
