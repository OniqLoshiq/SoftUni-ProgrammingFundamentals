using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_PhonebookUpgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            SortedDictionary<string, string> phoneBook = new SortedDictionary<string, string>();

            while (command != "END")
            {
                List<string> commandArgs = command.Split().ToList();

                if (commandArgs[0] == "A")
                {
                    phoneBook[commandArgs[1]] = commandArgs[2];
                }
                else if (commandArgs[0] == "S")
                {
                    if (phoneBook.ContainsKey(commandArgs[1]))
                    {
                        Console.WriteLine("{0} -> {1}", commandArgs[1], phoneBook[commandArgs[1]]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", commandArgs[1]);
                    }
                }
                else if(command == "ListAll")
                {
                    foreach (var log in phoneBook)
                    {
                        Console.WriteLine("{0} -> {1}", log.Key, log.Value);
                    }
                }

                command = Console.ReadLine();
            }
        }
    }
}
