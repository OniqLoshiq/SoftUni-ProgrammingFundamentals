using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            string reversedNumber = String.Empty;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                reversedNumber += number[i];
            }
            Console.WriteLine(reversedNumber);
            
            // Console.WriteLine(ReverseString(number));
        }

        
        static string ReverseString (string number)
        {
            char[] charArray = number.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
