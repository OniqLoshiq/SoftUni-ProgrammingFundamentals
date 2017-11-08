using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_CounterInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            for (;;)
            {
                try
                {
                    var input = int.Parse(Console.ReadLine());
                    counter++;
                }
                catch
                {
                    break;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
