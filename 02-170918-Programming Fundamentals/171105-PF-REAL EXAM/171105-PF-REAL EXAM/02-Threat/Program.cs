using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputText = Console.ReadLine().Split().ToList();

            while (true)
            {
                string[] cmd = Console.ReadLine().Split();
                if (cmd[0] == "3:1")
                {
                    break;
                }
                else if (cmd[0] == "merge")
                {
                    int startIndex = int.Parse(cmd[1]);
                    int endIndex = int.Parse(cmd[2]);

                    if (startIndex < 0) startIndex = 0;
                    if (startIndex > inputText.Count - 1) continue;
                    if (endIndex > inputText.Count - 1) endIndex = inputText.Count - 1;
                    if (endIndex < 0) continue;

                    string merged = String.Empty;

                    for (int i = 0; i <= endIndex - startIndex; i++)
                    {
                        merged += inputText[startIndex + i];
                    }
                    inputText[startIndex] = merged;
                    inputText.RemoveRange(startIndex + 1, endIndex - startIndex);
                }
                else if (cmd[0] == "divide")
                {
                    int index = int.Parse(cmd[1]);
                    int partitions = int.Parse(cmd[2]);

                    if (partitions == 0)
                    {
                        inputText.RemoveAt(index);
                        continue;
                    }
                    else if (partitions == 1)
                    {
                        continue;
                    }

                    int countSymbols = inputText[index].Length / partitions;
                    List<string> dividedIndex = new List<string>(partitions);

                    for (int i = 0; i < partitions - 1; i++)
                    {
                        dividedIndex.Add(inputText[index].Substring(0, countSymbols));
                        inputText[index] = inputText[index].Substring(countSymbols);
                    }
                    dividedIndex.Add(inputText[index]);
                    inputText.RemoveAt(index);
                    inputText.InsertRange(index, dividedIndex);
                }
            }
            Console.WriteLine(string.Join(" ", inputText));
        }
    }
}
