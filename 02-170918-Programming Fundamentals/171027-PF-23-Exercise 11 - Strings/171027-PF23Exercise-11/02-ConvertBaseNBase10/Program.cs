using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _02_ConvertBaseNBase10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int baseN = int.Parse(input[0]);
            string base10 = input[1];
                       
            BigInteger result = new BigInteger();

            for (int i = 0; i < base10.Length; i++)
            {
                result += int.Parse(base10[i].ToString()) * BigInteger.Pow(baseN, base10.Length - 1 - i);
            }
            
            Console.WriteLine(result);
        }
    }
}
