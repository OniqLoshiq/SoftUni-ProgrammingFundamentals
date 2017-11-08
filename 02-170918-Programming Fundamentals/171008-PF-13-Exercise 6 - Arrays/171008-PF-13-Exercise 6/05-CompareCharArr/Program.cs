using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_CompareCharArr
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] array1 = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] array2 = Console.ReadLine().Split().Select(char.Parse).ToArray();

            char[] shorterArray = GetShorterArray(array1, array2);
            char[] longerArray = GetLongerArray(array1, array2);
            bool checker = false;

            for (int i = 0; i < shorterArray.Length; i++)
            {
                if (longerArray[i] == shorterArray[i])
                {
                    checker = true;
                    continue;
                }
                else if (longerArray[i] > shorterArray[i])
                {
                    Console.WriteLine(string.Join("", shorterArray));
                    Console.WriteLine(string.Join("", longerArray));
                    break;

                }
                else
                {
                    Console.WriteLine(string.Join("", longerArray));
                    Console.WriteLine(string.Join("", shorterArray));
                    break;
                }
            }
            if(checker)
            {
                Console.WriteLine(string.Join("", shorterArray));
                Console.WriteLine(string.Join("", longerArray));
            }

        }

        static char[] GetShorterArray(char[]array1, char[]array2)
        {
            char[] shorterArray = new char[Math.Min(array1.Length, array2.Length)];

            if (array1.Length >= array2.Length) shorterArray = array2;
            else shorterArray = array1;

            return shorterArray;
        }
        static char[] GetLongerArray(char[] array1, char[] array2)
        {
            char[] longerArray = new char[Math.Max(array1.Length, array2.Length)];

            if (array1.Length >= array2.Length) longerArray = array1;
            else longerArray = array2;

            return longerArray;
        }
    }
}
