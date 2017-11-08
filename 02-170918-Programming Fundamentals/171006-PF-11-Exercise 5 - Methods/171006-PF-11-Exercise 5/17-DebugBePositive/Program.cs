using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_DebugBePositive
{
    class Program
    {
        static void Main(string[] args)
        {
            int countSequences = int.Parse(Console.ReadLine());


            for (int i = 0; i < countSequences; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var numbers = new List<int>();

                for (int j = 0; j < input.Length; j++)
                {
                    int num = int.Parse(input[j]);
                    numbers.Add(num);
                }

                bool found = false;
                int index = 0;
                for (int j = 0; j < numbers.Count; j += index + 1)
                {
                    int currentNum = numbers[j];

                    if (currentNum >= 0)
                    {
                        index = 0;
                        if (found)
                        {
                            Console.Write(" ");
                        }

                        Console.Write(currentNum);

                        found = true;
                    }
                    else if (j + 1 < numbers.Count)
                    {
                        currentNum += numbers[j + 1];
                        index = 1;
                        if (currentNum >= 0)
                        {
                            if (found)
                            {
                                Console.Write(" ");
                            }

                            Console.Write(currentNum);

                            found = true;
                        }
                    }
                }

                if (!found)
                {
                    Console.Write("(empty)");
                }
                Console.WriteLine();
            }
        }
    }
}
