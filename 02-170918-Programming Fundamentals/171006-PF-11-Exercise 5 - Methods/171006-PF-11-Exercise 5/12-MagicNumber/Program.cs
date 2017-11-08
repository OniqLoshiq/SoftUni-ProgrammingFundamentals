using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_MagicNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());

            for (long i = 16; i <= num; i++)
            {
                if (CheckSymmetric(i) && CheckDigitsDivideSeven(i) && CheckOneEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool CheckOneEvenDigit(long num)
        {
            bool isMagicNumberCheck3 = false;
            while (num > 0)
            {
                if (num % 2 == 0)
                {
                    isMagicNumberCheck3 = true;
                }
                num = num / 10;
                if (isMagicNumberCheck3) break;
            }
            return isMagicNumberCheck3;
        }

        private static bool CheckDigitsDivideSeven(long num)
        {
            long sumDigits = 0;
            bool isMagicNumberCheck2 = false;

            while (num > 0)
            {
                sumDigits += (num % 10);
                num = num / 10;
            }
            if (sumDigits % 7 == 0) isMagicNumberCheck2 = true;

            return isMagicNumberCheck2;

        }

        private static bool CheckSymmetric(long num)
        {
            bool isMagicNumberCheck1 = true;
            string sNumber = num.ToString();

            for (int i = 0; i < sNumber.Length / 2; i++)
            {
                if (sNumber[i] != sNumber[sNumber.Length - 1 - i])
                {
                    isMagicNumberCheck1 = false;
                    break;
                }
            }

            return isMagicNumberCheck1;
        }
    }
}
