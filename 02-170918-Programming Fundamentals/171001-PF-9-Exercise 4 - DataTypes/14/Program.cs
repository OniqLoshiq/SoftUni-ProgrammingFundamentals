using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string numHex = Convert.ToString(num, 16).ToUpper();
            string numBin = Convert.ToString(num, 2);

            Console.WriteLine(numHex);
            Console.WriteLine(numBin);

        }
    }
}
