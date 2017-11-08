using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CommandInterpreter
{
    class File
    {
        public string Root { get; set; }
        public string FileName { get; set; }
        public long FileSize { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputList = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            while (true)
            {
                string cmdInput = Console.ReadLine();
                if (cmdInput == "end") break;
                string invalidInput = "Invalid input parameters.";

                string[] cmdArgs = cmdInput.Split();

                if (cmdArgs[0] == "reverse" || cmdArgs[0] == "sort")
                {
                    int startIndex = int.Parse(cmdArgs[2]);
                    int count = int.Parse(cmdArgs[4]);

                    if (startIndex >= inputList.Count || count > inputList.Count || (startIndex + count) > inputList.Count || startIndex < 0 || count < 0)
                    {
                        Console.WriteLine(invalidInput);
                    }
                    else
                    {
                        switch (cmdArgs[0])
                        {
                            case "reverse": inputList = ReverseList(inputList, startIndex, count); break;
                            case "sort": inputList = SortList(inputList, startIndex, count); break;
                        }
                    }

                }
                else if (cmdArgs[0] == "rollLeft" || cmdArgs[0] == "rollRight")
                {
                    int count = int.Parse(cmdArgs[1]);

                    if (count < 0) Console.WriteLine(invalidInput);
                    else
                    {
                        switch (cmdArgs[0])
                        {
                            case "rollLeft": inputList = RollLeftList(inputList, count); break;
                            case "rollRight": inputList = RollRightList(inputList, count); break;
                        }
                    }
                }
            }

            Console.WriteLine("[{0}]", string.Join(", ", inputList));
        }

        private static List<string> RollRightList(List<string> inputList, int count)
        {
            count = count % inputList.Count;
            for (int i = 0; i < count; i++)
            {
                List<string> rolledList = new List<string>(inputList.Count);

                rolledList.Add(inputList[inputList.Count - 1]);

                for (int j = 0; j < inputList.Count - 1; j++)
                {
                    rolledList.Add(inputList[j]);
                }

                inputList = rolledList;
            }

            return inputList;
        }

        private static List<string> RollLeftList(List<string> inputList, int count)
        {
            count = count % inputList.Count;
            for (int i = 0; i < count; i++)
            {
                List<string> rolledList = new List<string>();

                for (int j = 0; j < inputList.Count; j++)
                {
                    rolledList.Add(inputList[(j + 1) % inputList.Count]);
                }
                inputList = rolledList;
            }

            return inputList;
        }

        private static List<string> SortList(List<string> inputList, int startIndex, int count)
        {
            List<string> sortedList = inputList.Skip(startIndex).Take(count).OrderBy(x => x).ToList();

            for (int i = 0; i < count; i++)
            {
                inputList[startIndex + i] = sortedList[i];
            }

            return inputList;
        }

        private static List<string> ReverseList(List<string> inputList, int startIndex, int count)
        {
            string temp = String.Empty;

            for (int i = 0; i < count / 2; i++)
            {
                temp = inputList[i + startIndex];
                inputList[i + startIndex] = inputList[startIndex + count - 1 - i];
                inputList[startIndex + count - 1 - i] = temp;
            }

            return inputList;
        }
    }
}



