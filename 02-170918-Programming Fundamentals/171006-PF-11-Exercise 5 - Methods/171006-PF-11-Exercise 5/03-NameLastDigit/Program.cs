using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_NameLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            Console.WriteLine(GetNameOfLastDigit(n));
        }

        static string GetNameOfLastDigit(long n)
        {
            n = Math.Abs(n);
            long lastDigit = n % 10;
            string nameOfDigit = String.Empty;
            switch (lastDigit)
            {
                case 0: nameOfDigit = "zero"; break;
                case 1: nameOfDigit = "one"; break;
                case 2: nameOfDigit = "two"; break;
                case 3: nameOfDigit = "three"; break;
                case 4: nameOfDigit = "four"; break;
                case 5: nameOfDigit = "five"; break;
                case 6: nameOfDigit = "six"; break;
                case 7: nameOfDigit = "seven"; break;
                case 8: nameOfDigit = "eight"; break;
                case 9: nameOfDigit = "nine"; break;
                default: break;
            }
            return nameOfDigit;
        }
    }
}
