using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02_HornetComm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> privateMSGs = new List<string>();
            List<string> broadcastS = new List<string>();

            while (true)
            {
                string inputLine = Console.ReadLine();
                if (inputLine == "Hornet is Green")
                {
                    break;
                }
                string privateMsg = @"^([0-9]+)( <-> )([a-zA-Z0-9]+)$";
                string broadcast = @"^([^0-9]+)( <-> )([a-zA-Z0-9]+)$";

                if (Regex.IsMatch(inputLine, privateMsg))
                {
                    Match validMsg = Regex.Match(inputLine, privateMsg);

                    string codeMsg = validMsg.Groups[1].ToString();
                    string msg = validMsg.Groups[3].ToString();

                    char[] reverseStr = codeMsg.ToCharArray();
                    Array.Reverse(reverseStr);
                    codeMsg = new string(reverseStr);

                    privateMSGs.Add($"{codeMsg} -> {msg}");
                }
                else if (Regex.IsMatch(inputLine, broadcast))
                {
                    Match validMsg = Regex.Match(inputLine, broadcast);

                    string msg = validMsg.Groups[1].ToString();
                    string frequency = validMsg.Groups[3].ToString();

                    char[] frqnc = new char[frequency.Length];

                    for (int i = 0; i < frequency.Length; i++)
                    {
                        if (frequency[i] >= 65 && frequency[i] <= 90)
                            frqnc[i] = Char.ToLower(frequency[i]);

                        else if (frequency[i] >= 97 && frequency[i] <= 122)
                            frqnc[i] = Char.ToUpper(frequency[i]);

                        else
                            frqnc[i] = frequency[i];
                    }
                    frequency = new string(frqnc);

                    broadcastS.Add($"{frequency} -> {msg}");
                }
            }

            Console.WriteLine("Broadcasts:");
            if (broadcastS.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var item in broadcastS)
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine("Messages:");
            if (privateMSGs.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var item in privateMSGs)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
