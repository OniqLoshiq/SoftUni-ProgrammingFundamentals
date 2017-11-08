using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04_CubicMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> allOutputs = new List<string>();

            while (true)
            {
                string msg = Console.ReadLine();
                if (msg == "Over!")
                {
                    break;
                }
                int m = int.Parse(Console.ReadLine());

                Regex pattern = new Regex(@"^(\d+)([a-zA-Z]+)([^a-zA-Z]*)$");
                if (!pattern.IsMatch(msg))
                {
                    continue;
                }

                Match validMsg = pattern.Match(msg);

                string firstNums = validMsg.Groups[1].Value;
                string msgText = validMsg.Groups[2].Value;
                string secondPart = validMsg.Groups[3].Value;
                Regex regex = new Regex(@"\d+");
                MatchCollection secondNumsMatch = regex.Matches(secondPart);
                foreach (var num in secondNumsMatch)
                {
                    firstNums += num;
                }

                if (msgText.Length != m)
                {
                    continue;
                }

                string decodedMsg = String.Empty;

                for (int i = 0; i < firstNums.Length; i++)
                {
                    int index = int.Parse(firstNums[i].ToString());

                    if (index > msgText.Length - 1)
                    {
                        decodedMsg += " ";
                    }
                    else
                    {
                        decodedMsg += msgText[index];
                    }
                }

                string output = $"{msgText} == {decodedMsg}";
                allOutputs.Add(output);
            }
            Console.WriteLine(string.Join(Environment.NewLine, allOutputs));

        }
    }
}

