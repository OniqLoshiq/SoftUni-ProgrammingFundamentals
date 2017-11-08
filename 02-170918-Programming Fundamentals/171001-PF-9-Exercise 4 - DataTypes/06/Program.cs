using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";

            object together = hello + " " + world;
            string print = (string)together;
               

            Console.WriteLine(print);
        }
    }
}
