using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_LettersChangeNums
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputLine = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            double sum = 0.0;

            char[] alphabet = new char[26];

            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = (char)('a' + i);
            }

            foreach (var item in inputLine)
            {
                double numberInString = double.Parse((item.Remove(0, 1).Remove(item.Length - 2, 1).ToString()));

                if (numberInString != 0.0)
                {
                    int firstIndex = Array.IndexOf(alphabet, item.ToLower()[0]) + 1;
                    int secondIndex = Array.IndexOf(alphabet, item.ToLower()[item.Length - 1]) + 1;

                    if (item[0] >= 97 && item[0] <= 122)
                    {
                        numberInString *= firstIndex;
                    }
                    else
                    {
                        numberInString /= firstIndex;
                    }

                    if (item[item.Length - 1] >= 97 && item[item.Length - 1] <= 122)
                    {
                        numberInString += secondIndex;
                    }
                    else
                    {
                        numberInString -= secondIndex;
                    }
                }
                sum += numberInString;
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}
