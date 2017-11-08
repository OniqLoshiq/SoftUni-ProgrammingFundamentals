using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            string boolean = Console.ReadLine();

            bool check = Convert.ToBoolean(boolean);
            string print = check == true ? "Yes" : "No";
            Console.WriteLine("{0}", print);
        }
    }
}
