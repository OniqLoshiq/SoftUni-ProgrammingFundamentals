using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexNum = Console.ReadLine();

            Console.WriteLine("{0}", Convert.ToInt32(hexNum, 16));
        }
    }
}
