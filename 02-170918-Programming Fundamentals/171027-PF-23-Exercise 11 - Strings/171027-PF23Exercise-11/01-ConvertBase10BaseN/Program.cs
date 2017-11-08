using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace _01_ConvertBase10BaseN
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            long baseN = long.Parse(input[0]);
            BigInteger base10 = BigInteger.Parse(input[1]);

            List<BigInteger> numberN = new List<BigInteger>();
            BigInteger residue = new BigInteger();

            while (base10 != 0)
            {
                residue = base10 % baseN;
                base10 /= baseN;
                numberN.Add(residue);
            }
            numberN.Reverse();
            string searcherdN = string.Join("", numberN);

            Console.WriteLine(searcherdN);

        }
    }
}
