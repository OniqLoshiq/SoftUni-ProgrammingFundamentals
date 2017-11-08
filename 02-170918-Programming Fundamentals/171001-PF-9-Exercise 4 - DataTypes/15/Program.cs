using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int num = 2; num <= n; num++)
            {
                bool checker = true;
                for (int numDivide = 2; numDivide <= Math.Sqrt(num); numDivide++)
                {
                    if (num % numDivide == 0)
                    {
                        checker = false;
                        break;
                    }
                }
                Console.WriteLine($"{num} -> {checker}");
            }

        }
    }
}
