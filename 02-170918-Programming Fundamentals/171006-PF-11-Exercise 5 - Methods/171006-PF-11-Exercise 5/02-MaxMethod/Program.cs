using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMax(n1, GetMax(n2, n3)));
        }

        static int GetMax(int n1, int n2)
        {
            return Math.Max(n1, n2);
        }

    }
}
