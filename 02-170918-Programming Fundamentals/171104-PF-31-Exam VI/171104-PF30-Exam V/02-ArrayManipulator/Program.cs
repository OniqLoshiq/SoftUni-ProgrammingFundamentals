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
            List<int> inputList = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string[] cmd = Console.ReadLine().Split();
                if (cmd[0] == "end")
                {
                    break;
                }

                if (cmd[0] == "exchange")
                {
                    int index = int.Parse(cmd[1]);

                    if (index > inputList.Count - 1 || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        inputList = GetExchangedList(inputList, index);
                    }
                }
                else if (cmd[1] == "odd")
                {
                    bool isOdd = false;
                    for (int i = 0; i < inputList.Count; i++)
                    {
                        if (inputList[i] % 2 == 1)
                        {
                            isOdd = true;
                            break;
                        }
                    }
                    if (isOdd)
                    {
                        GetOddIndex(inputList, cmd[0]);
                    }
                    else
                    {
                        Console.WriteLine("No matches");
                    }
                }
                else if (cmd[1] == "even")
                {
                    bool isEven = false;
                    for (int i = 0; i < inputList.Count; i++)
                    {
                        if (inputList[i] % 2 == 0)
                        {
                            isEven = true;
                            break;
                        }
                    }
                    if (isEven)
                    {
                        GetEvenIndex(inputList, cmd[0]);
                    }
                    else
                    {
                        Console.WriteLine("No matches");
                    }
                }
                else if (cmd[0] == "first")
                {
                    int count = int.Parse(cmd[1]);
                    if (count > inputList.Count)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        GetFirst(inputList, count, cmd[2]);
                    }
                }
                else if (cmd[0] == "last")
                {
                    int count = int.Parse(cmd[1]);
                    GetLast(inputList, count, cmd[2]);
                }
            }
            Console.WriteLine($"[{string.Join(", ", inputList)}]");
        }

        private static void GetLast(List<int> inputList, int count, string v)
        {
            if (v == "odd")
            {
                bool isOdd = false;
                for (int i = 0; i < inputList.Count; i++)
                {
                    if (inputList[i] % 2 == 1)
                    {
                        isOdd = true;
                        break;
                    }
                }
                if (isOdd)
                {
                    List<int> oddList = inputList.Where(z => z % 2 == 1).ToList();
                    if (oddList.Count > count)
                    {
                        oddList = oddList.Skip(oddList.Count - count).ToList();
                    }

                    Console.WriteLine($"[{string.Join(", ", oddList)}]");

                }
                else
                {
                    Console.WriteLine("[]");
                }
            }
            else
            {
                bool isEven = false;
                for (int i = 0; i < inputList.Count; i++)
                {
                    if (inputList[i] % 2 == 0)
                    {
                        isEven = true;
                        break;
                    }
                }
                if (isEven)
                {
                    List<int> evenList = inputList.Where(z => z % 2 == 0).Take(count).ToList();
                    if (evenList.Count > count)
                    {
                        evenList = evenList.Skip(evenList.Count - count).ToList();
                    }

                    Console.WriteLine($"[{string.Join(", ", evenList)}]");
                }
                else
                {
                    Console.WriteLine("[]");
                }
            }
        }

        private static void GetFirst(List<int> inputList, int count, string v)
        {
            if (v == "odd")
            {
                bool isOdd = false;
                for (int i = 0; i < inputList.Count; i++)
                {
                    if (inputList[i] % 2 == 1)
                    {
                        isOdd = true;
                        break;
                    }
                }
                if (isOdd)
                {
                    List<int> oddList = inputList.Where(z => z % 2 == 1).Take(count).ToList();
                    Console.WriteLine($"[{string.Join(", ", oddList)}]");
                }
                else
                {
                    Console.WriteLine("[]");
                }
            }
            else
            {
                bool isEven = false;
                for (int i = 0; i < inputList.Count; i++)
                {
                    if (inputList[i] % 2 == 0)
                    {
                        isEven = true;
                        break;
                    }
                }
                if (isEven)
                {
                    List<int> evenList = inputList.Where(z => z % 2 == 0).Take(count).ToList();
                    Console.WriteLine($"[{string.Join(", ", evenList)}]");
                }
                else
                {
                    Console.WriteLine("[]");
                }
            }
        }

        private static void GetEvenIndex(List<int> inputList, string v)
        {
            if (v == "max")
            {
                int maxValue = inputList.Where(z => z % 2 == 0).Max();
                int maxIndex = inputList.LastIndexOf(maxValue);
                Console.WriteLine(maxIndex);
            }
            else
            {
                int minValue = inputList.Where(z => z % 2 == 0).Min();
                int minIndex = inputList.LastIndexOf(minValue); ;
                Console.WriteLine(minIndex);
            }
        }

        private static void GetOddIndex(List<int> inputList, string v)
        {
            if (v == "max")
            {
                int maxValue = inputList.Where(z => z % 2 == 1).Max();
                int maxIndex = inputList.LastIndexOf(maxValue);
                Console.WriteLine(maxIndex);
            }
            else
            {
                int minValue = inputList.Where(z => z % 2 == 1).Min();
                int minIndex = inputList.LastIndexOf(minValue); ;
                Console.WriteLine(minIndex);
            }

        }

        private static List<int> GetExchangedList(List<int> inputList, int index)
        {
            List<int> temp1 = inputList.Skip(index + 1).ToList();
            List<int> temp2 = inputList.Take(index + 1).ToList();
            return inputList = temp1.Concat(temp2).ToList();

        }
    }
}
