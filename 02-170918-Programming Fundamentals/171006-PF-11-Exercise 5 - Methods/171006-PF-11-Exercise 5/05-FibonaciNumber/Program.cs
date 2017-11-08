using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_FibonaciNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int firstNumber = 1;
            int secondNumber = 1;
            int fibonachiNumber = 1;

            for (int i = 1; i < n; i++)
            {
                fibonachiNumber += firstNumber;

                firstNumber = secondNumber;
                secondNumber = fibonachiNumber;
            }

            Console.WriteLine(fibonachiNumber);
        }
    }
}
