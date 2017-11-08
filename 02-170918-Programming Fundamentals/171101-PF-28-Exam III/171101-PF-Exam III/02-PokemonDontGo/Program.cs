using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputSeq = Console.ReadLine().Split().Select(int.Parse).ToList();

            ulong totalSum = 0L;

            while (inputSeq.Count != 0)
            {
                int index = int.Parse(Console.ReadLine());
                int indexValue = 0;

                if (index < 0)
                {
                    indexValue = inputSeq[0];
                    inputSeq[0] = inputSeq[inputSeq.Count - 1];
                }
                else if (index > inputSeq.Count - 1)
                {
                    indexValue = inputSeq[inputSeq.Count - 1];
                    inputSeq[inputSeq.Count - 1] = inputSeq[0];
                }
                else
                {
                    indexValue = inputSeq[index];
                    inputSeq.RemoveAt(index);
                }

                for (int i = 0; i < inputSeq.Count; i++)
                {
                    if (inputSeq[i] <= indexValue) inputSeq[i] += indexValue;
                    else inputSeq[i] -= indexValue;
                }

                totalSum += (ulong)indexValue;
            }

            Console.WriteLine(totalSum);

        }
    }
}
