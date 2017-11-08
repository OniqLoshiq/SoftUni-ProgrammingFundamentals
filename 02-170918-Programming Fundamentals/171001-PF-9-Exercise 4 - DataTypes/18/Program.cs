using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _18
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger num = BigInteger.Parse(Console.ReadLine());

            if (num >= -9223372036854775808 && num <= 9223372036854775807)
            {
                Console.WriteLine($"{num} can fit in:");
                if (num <= 127 && num >= -128) Console.WriteLine("* sbyte");
                if (num <= 255 && num >= 0) Console.WriteLine("* byte");
                if (num <= 32767 && num >= -32768) Console.WriteLine("* short");
                if (num <= 65535 && num >= 0) Console.WriteLine("* ushort");
                if (num <= 2147483647 && num >= -2147483648) Console.WriteLine("* int");
                if (num <= 4294967295 && num >= 0) Console.WriteLine("* uint");
                Console.WriteLine("* long");
            }
            else
            { Console.WriteLine($"{num} can't fit in any type"); }
        }
    }
}
