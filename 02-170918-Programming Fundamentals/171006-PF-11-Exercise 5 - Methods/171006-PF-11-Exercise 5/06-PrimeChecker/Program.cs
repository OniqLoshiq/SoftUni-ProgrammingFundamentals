using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            Console.WriteLine(IsPrime(n));
        }

        static bool IsPrime(long n)
        {
            bool isPrime = true;

            if (n == 0 || n == 1) isPrime = false;
            else if (n == 2) isPrime = true;
            else if (n % 2 == 0) isPrime = false;
            else
            {
                for (int i = 3; i <= Math.Ceiling(Math.Sqrt(n)); i += 2)
                {
                    if (n % i == 0) isPrime = false;
                    else isPrime = true;
                }
            }
            return isPrime;

        }
    }
}
