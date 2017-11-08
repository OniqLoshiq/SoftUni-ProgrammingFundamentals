using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06__IntervalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int num1 = Math.Max(a, b);
            int num2 = Math.Min(a, b);

            for (int i = num2; i <= num1; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
