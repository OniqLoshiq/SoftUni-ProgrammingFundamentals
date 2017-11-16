using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> data = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string[] cmdArgs = Console.ReadLine().Split();
                if (cmdArgs[0] == "end")
                {
                    break;
                }
                string cmd = cmdArgs[0];

                switch (cmd)
                {
                    case "exchange":
                        int index = int.Parse(cmdArgs[1]);
                        if (index < 0 || index > data.Count - 1)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            data = ExchangeList(data, index);
                        }
                        break;
                    case "max": GetMax(data, cmdArgs); break;
                    case "min": GetMin(data, cmdArgs); break;
                    case "first": GetFirst(data, cmdArgs); break;
                    case "last": GetLast(data, cmdArgs); break;
                }
            }
            Console.WriteLine($"[{string.Join(", ", data)}]");
        }

        private static void GetLast(List<int> data, string[] cmdArgs)
        {
            int count = int.Parse(cmdArgs[1]);
            string cmd = cmdArgs[2];

            if (count > data.Count)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                List<int> partOfTheData = new List<int>();

                if (cmd == "odd")
                {
                    partOfTheData = data.Where(x => x % 2 != 0).ToList();

                    if (partOfTheData.Count > count)
                    {
                        partOfTheData = partOfTheData.Skip(partOfTheData.Count - count).ToList();
                    }
                }
                else if (cmd == "even")
                {
                    partOfTheData = data.Where(x => x % 2 == 0).ToList();

                    if (partOfTheData.Count > count)
                    {
                        partOfTheData = partOfTheData.Skip(partOfTheData.Count - count).ToList();
                    }
                }

                if (partOfTheData.Count < 1)
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    Console.WriteLine($"[{string.Join(", ", partOfTheData)}]");
                }
            }
        }

        private static void GetFirst(List<int> data, string[] cmdArgs)
        {
            int count = int.Parse(cmdArgs[1]);
            string cmd = cmdArgs[2];

            if (count > data.Count)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                List<int> partOfTheData = new List<int>();

                if (cmd == "odd")
                {
                    partOfTheData = data.Where(x => x % 2 != 0).Take(count).ToList();
                }
                else if (cmd == "even")
                {
                    partOfTheData = data.Where(x => x % 2 == 0).Take(count).ToList();
                }

                if (partOfTheData.Count < 1)
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    Console.WriteLine($"[{string.Join(", ", partOfTheData)}]");
                }
            }
        }

        private static void GetMin(List<int> data, string[] cmdArgs)
        {
            string cmd = cmdArgs[1];
            int minElement = 0;

            if (cmd == "odd")
            {
                bool containsOdd = true;
                for (int i = 0; i < data.Count; i++)
                {
                    if (data[i] % 2 != 0)
                    {
                        containsOdd = false;
                        break;
                    }
                }
                if (containsOdd)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    minElement = data.LastIndexOf(data.Where(x => x % 2 != 0).Min());
                    Console.WriteLine(minElement);
                }
            }
            else if (cmd == "even")
            {
                bool containsEven = true;
                for (int i = 0; i < data.Count; i++)
                {
                    if (data[i] % 2 == 0)
                    {
                        containsEven = false;
                        break;
                    }
                }
                if (containsEven)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    minElement = data.LastIndexOf(data.Where(x => x % 2 == 0).Min());
                    Console.WriteLine(minElement);
                }
            }
        }

        private static void GetMax(List<int> data, string[] cmdArgs)
        {
            string cmd = cmdArgs[1];
            int maxElement = 0;

            if (cmd == "odd")
            {
                bool containsOdd = true;
                for (int i = 0; i < data.Count; i++)
                {
                    if (data[i] % 2 != 0)
                    {
                        containsOdd = false;
                        break;
                    }
                }
                if (containsOdd)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    maxElement = data.LastIndexOf(data.Where(x => x % 2 != 0).Max());
                    Console.WriteLine(maxElement);
                }
            }
            else if (cmd == "even")
            {
                bool containsEven = true;
                for (int i = 0; i < data.Count; i++)
                {
                    if (data[i] % 2 == 0)
                    {
                        containsEven = false;
                        break;
                    }
                }
                if (containsEven)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    maxElement = data.LastIndexOf(data.Where(x => x % 2 == 0).Max());
                    Console.WriteLine(maxElement);
                }
            }
        }

        private static List<int> ExchangeList(List<int> data, int index)
        {
            List<int> temp = data.Take(index + 1).ToList();
            data = data.Skip(index + 1).ToList();
            data.AddRange(temp);
            return data;
        }
    }
}
