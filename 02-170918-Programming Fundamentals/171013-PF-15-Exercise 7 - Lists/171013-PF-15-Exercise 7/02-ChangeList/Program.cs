using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] command = Console.ReadLine().Split();

            while (command[0] != "Odd" && command[0] != "Even")
            {
                switch (command[0])
                {
                    case "Delete":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers.Contains(int.Parse(command[1])))
                            {
                                numbers.Remove(int.Parse(command[1]));
                            }
                        }
                        break;
                    case "Insert": numbers.Insert(int.Parse(command[2]), int.Parse(command[1])); break;
                }
                command = Console.ReadLine().Split();
            }

            if (command[0] == "Odd") Console.WriteLine(string.Join(" ", OddNums(numbers)));
            else if (command[0] == "Even") Console.WriteLine(string.Join(" ", EvenNums(numbers)));
        }

        static List<int> OddNums(List<int> numbers)
        {
            List<int> oddNums = new List<int>();

            foreach (var num in numbers)
            {
                if (num % 2 != 0)
                    oddNums.Add(num);
            }

            return oddNums;
        }

        static List<int> EvenNums(List<int> numbers)
        {
            List<int> evenNums = new List<int>();

            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                    evenNums.Add(num);
            }
            return evenNums;
        }
    }
}
