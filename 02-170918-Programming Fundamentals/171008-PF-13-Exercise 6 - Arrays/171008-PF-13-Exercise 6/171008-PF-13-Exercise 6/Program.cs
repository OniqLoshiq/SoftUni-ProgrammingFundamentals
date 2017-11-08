using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine().Split();
            string[] array2 = Console.ReadLine().Split();

            int counterL = 0;
            int counterR = 0;

            string[] shorterArr = EstimateShorterArr(array1, array2);
            string[] longerArr = EstimateLongerArr(array1, array2);

            for (int i = 0; i < shorterArr.Length; i++)
            {
                if (shorterArr[i] == longerArr[i])
                {
                    counterL++;
                }
                else break;
            }
            for (int i = 0; i < shorterArr.Length; i++)
            {
                if (shorterArr[shorterArr.Length - 1 - i] == longerArr[longerArr.Length - 1 - i])
                {
                    counterR++;
                }
                else break;
            }

            Console.WriteLine(Math.Max(counterL, counterR));

        }

        static string[] EstimateShorterArr(string[] array1, string[] array2)
        {
            string[] shorterArr = new string[0];

            if (array1.Length > array2.Length)
            {
                shorterArr = array2;
            }
            else
            {
                shorterArr = array1;
            }

            return shorterArr;
        }

        static string[] EstimateLongerArr(string[] array1, string[] array2)
        {
            string[] longerArr = new string[0];

            if (array1.Length > array2.Length)
            {
                longerArr = array1;
            }
            else
            {
                longerArr = array2;
            }

            return longerArr;
        }
    }
}