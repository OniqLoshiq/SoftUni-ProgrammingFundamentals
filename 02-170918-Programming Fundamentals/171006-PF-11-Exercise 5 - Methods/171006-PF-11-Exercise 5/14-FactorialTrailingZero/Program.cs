using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _14_FactorialTrailingZero
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;

            for (int i = n; i >= 1; i--)
            {
                factorial *= i;
            }

            CountLastZeroes(factorial);
        }
        static void CountLastZeroes(BigInteger factorial)
        {
            int counter = 0;

            while (factorial % 10 == 0)
            {
                counter++;
                factorial /= 10;
            }

            Console.WriteLine(counter);
        }
    }
}
