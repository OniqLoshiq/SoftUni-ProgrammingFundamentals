using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "print")
            {
                string[] commandsArg = command.Split();

                switch (commandsArg[0])
                {
                    case "add":
                        numbers.Insert(int.Parse(commandsArg[1]), int.Parse(commandsArg[2]));
                        break;

                    case "addMany":
                        int index = int.Parse(commandsArg[1]);

                        for (int i = 0; i < commandsArg.Length - 2; i++)
                        {
                            numbers.Insert(index + i, int.Parse(commandsArg[2 + i]));
                        }
                        break;

                    case "contains":
                        int element = int.Parse(commandsArg[1]);
                        if (numbers.Contains(element))
                        {
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] == element)
                                {
                                    Console.WriteLine(i);
                                    break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("-1");
                        }
                        break;

                    case "remove":
                        numbers.RemoveAt(int.Parse(commandsArg[1]));
                        break;

                    case "shift":
                        int position = int.Parse(commandsArg[1]);
                        List<int> tempList1 = new List<int>();
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            tempList1.Add( numbers[((numbers.Count + position) + i) % numbers.Count]);
                        }
                        numbers = tempList1;
                        break;

                    case "sumPairs":
                        List<int> tempList2 = new List<int>();

                        if (numbers.Count % 2 == 0)
                        {
                            for (int i = 0; i < numbers.Count; i += 2)
                            {
                                tempList2.Add(numbers[i] + numbers[i + 1]);
                            }
                            numbers = tempList2;
                        }
                        else
                        {
                            for (int i = 0; i < numbers.Count - 1; i += 2)
                            {
                                tempList2.Add(numbers[i] + numbers[i + 1]);
                            }
                            tempList2.Add(numbers[numbers.Count - 1]);
                            numbers = tempList2;
                        }
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }
    }
}
