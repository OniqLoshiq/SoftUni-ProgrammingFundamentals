using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_PrimesGiven
{
    class Program
    {
        static void Main(string[] args)
        {
            int nStart = int.Parse(Console.ReadLine());
            int nEnd = int.Parse(Console.ReadLine());

            CheckIsPrime(nStart, nEnd);
        }

        static void CheckIsPrime(int nStart, int nEnd)
        {
            List<int> numbers = new List<int>();

            if (nStart > nEnd)
            {
                Console.WriteLine("(empty string)");
            }

            for (int i = nStart; i <= nEnd; i++)
            {
                bool isPrime = true;
                if (i == 0 || i == 1) isPrime = false;
                else if (i == 2) isPrime = true;
                else if (i % 2 == 0) isPrime = false;
                else
                {
                    for (int j = 3; j <= Math.Ceiling(Math.Sqrt(i)); j += 2)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                        else isPrime = true;
                    }
                }
                if (isPrime)
                {
                    numbers.Add(i);
                }
            }
            PrintList(numbers);
        }

        static void PrintList(List<int> numbers)
        {
            Console.WriteLine(string.Join(", ", numbers));
        }
    }

}

