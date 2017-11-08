using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = (Console.ReadLine());

            int checkInt;
            if (Int32.TryParse(input, out checkInt))
            {
                Console.WriteLine("digit");
            }
            else if (input == "a" || input == "e" || input == "i" || input == "o" || input == "u" || input == "y")
            {
                Console.WriteLine("vowel");
            }
            else Console.WriteLine("other");
           
           
        }
    }
}
