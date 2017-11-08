using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07___MultiplyBigNum
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine().TrimStart('0');
            string num2 = Console.ReadLine();

            if (num2 == "0")
            {
                Console.WriteLine(0);
            }
            else
            {
                num1 = new string(num1.Reverse().ToArray());

                int plusSecondDigit = 0;
                string reversedProduct = String.Empty;

                for (int i = 0; i < num1.Length; i++)
                {
                    int productDigets = int.Parse(num1[i].ToString()) * int.Parse(num2) + plusSecondDigit;

                    int addNum = productDigets % 10;
                    reversedProduct += addNum;
                    plusSecondDigit = productDigets / 10;

                    if (i == num1.Length - 1 && plusSecondDigit > 0)
                    {
                        reversedProduct += plusSecondDigit;
                    }
                }

                string sum = new string(reversedProduct.Reverse().ToArray());
                Console.WriteLine(sum);
            }
        }
    }
}
