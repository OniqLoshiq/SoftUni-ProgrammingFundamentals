using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_SearchNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNums = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] commandNums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            inputNums.Take(commandNums[0]);

            for (int i = 0; i < commandNums[1]; i++)
            {
                inputNums.RemoveAt(0);
            }
            if(inputNums.Contains(commandNums[2]))
            {
                Console.WriteLine("YES!");
            }
            else Console.WriteLine("NO!");
        }
    }
}
