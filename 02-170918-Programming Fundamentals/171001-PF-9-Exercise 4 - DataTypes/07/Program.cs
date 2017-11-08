using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int tempVariable = b;

            Console.WriteLine($"Before:\na = {a}\nb = {b}");
           
            b = a;
            a = tempVariable;

            Console.WriteLine($"After:{Environment.NewLine}a = {a}{Environment.NewLine}b = {b}");
        }
    }
}
