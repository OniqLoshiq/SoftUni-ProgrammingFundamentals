using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {
            int numStart = int.Parse(Console.ReadLine());
            int numEnd = int.Parse(Console.ReadLine());

            for (int i = numStart; i <= numEnd; i++)
            {
                Console.Write("{0} ", (char)i);
            }
        }
    }
}
