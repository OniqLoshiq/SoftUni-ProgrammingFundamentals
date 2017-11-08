using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SieveEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> allPrimes = new List<int>();
            bool[] primes = new bool[n + 1];

            primes[0] = false;
            primes[1] = false;

            for (int i = 2; i <= n; i++)
            {
                primes[i] = true;
            }
            for (int i = 1; i <= n; i++)
            {
                if (primes[i])
                {
                    allPrimes.Add(i);

                    for (int j = 2; i * j <= n; j++)
                    {
                        primes[i * j] = false;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", allPrimes));

        }
    }
}
