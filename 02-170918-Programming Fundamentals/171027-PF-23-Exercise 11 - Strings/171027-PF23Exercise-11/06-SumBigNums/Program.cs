using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_SumBigNums
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine().TrimStart('0');
            string num2 = Console.ReadLine().TrimStart('0');


            if (num1.Length < num2.Length)
            {
                string tempSTR = num2;
                num2 = new string(num1.Reverse().ToArray());
                num1 = new string(tempSTR.Reverse().ToArray());
            }
            else
            {
                num2 = new string(num2.Reverse().ToArray());
                num1 = new string(num1.Reverse().ToArray());
            }
            int onePlus = 0;
            string reversedSum = String.Empty;

            for (int i = 0; i < num1.Length; i++)
            {
                int sumDigits = 0;
                if (num2.Length > i)
                {
                    sumDigits = int.Parse(num1[i].ToString()) + int.Parse(num2[i].ToString()) + onePlus;
                }
                else
                {
                    sumDigits = int.Parse(num1[i].ToString()) + onePlus;
                }

                int addNum = sumDigits % 10;
                reversedSum += addNum;
                onePlus = sumDigits / 10;

                if(i == num1.Length - 1 && onePlus == 1)
                {
                    reversedSum += 1;
                }
            }

            string sum = new string(reversedSum.Reverse().ToArray());

            Console.WriteLine(sum);

        }
    }
}
