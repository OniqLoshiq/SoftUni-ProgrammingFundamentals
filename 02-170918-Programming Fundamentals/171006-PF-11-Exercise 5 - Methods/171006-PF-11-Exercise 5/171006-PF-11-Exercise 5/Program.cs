using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _171006_PF_11_Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            Console.WriteLine(PrintName(name));
        }
        static string PrintName(string name)
        {
           return "Hello, " + name + "!";
        }
    }
}
