using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_SumReversedNum
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    int checker = numbers[i];
            //    int reversed = 0;
            //    while (checker % 10 > 0 || checker != 0)
            //    {
            //        reversed = reversed * 10 + checker % 10;

            //        checker /= 10;
            //    }
            //    numbers[i] = reversed;

            //}
            //int sum = numbers.Sum();

            //Console.WriteLine(sum);

            List<string> numbers = Console.ReadLine().Split().ToList();

            List<int> realNums = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                realNums.Add(int.Parse(new string(numbers[i].Reverse().ToArray())));
            }

            Console.WriteLine(realNums.Sum());
        }
    }
}
