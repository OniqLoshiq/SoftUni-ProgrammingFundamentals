using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Cache
{
    class Program
    {
        static void Main(string[] args)
        {
            var allSets = new Dictionary<string, Dictionary<string, long>>();
            var allCache = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                string[] inputData = Console.ReadLine().Split();
                if (inputData[0] == "thetinggoesskrra")
                    break;

                if (inputData.Length == 1)
                {
                    string setName = inputData[0];

                    if (allCache.ContainsKey(setName))
                    {
                        allSets[setName] = new Dictionary<string, long>(allCache[setName]);

                        allCache.Remove(setName);
                    }

                    if (!allSets.ContainsKey(setName))
                    {
                        allSets[setName] = new Dictionary<string, long>();
                    }
                }

                else
                {
                    string setName = inputData[4];
                    string setKey = inputData[0];
                    long setSize = long.Parse(inputData[2]);

                    if (allSets.ContainsKey(setName))
                    {
                        allSets[setName].Add(setKey, setSize);
                    }
                    else if (!allCache.ContainsKey(setName))
                    {
                        allCache[setName] = new Dictionary<string, long>();
                        allCache[setName].Add(setKey, setSize);
                    }
                    else
                    {
                        allCache[setName].Add(setKey, setSize);
                    }
                }
            }

            if (allSets.Count > 0)
            {
                long maxSum = 0L;

                foreach (var set in allSets)
                {
                    long sum = 0L;
                    foreach (var item in set.Value)
                    {
                        sum += item.Value;
                    }
                    if (maxSum < sum)
                    {
                        maxSum = sum;
                    }
                }

                int counter = 1;
                foreach (var set in allSets.Where(x => x.Value.Values.Sum() == maxSum))
                {

                    if (counter == 1)
                    {
                        Console.WriteLine($"Data Set: {set.Key}, Total Size: {maxSum}");

                        foreach (var key in set.Value)
                        {
                            Console.WriteLine($"$.{key.Key}");
                        }
                        counter++;
                    }
                }
            }
        }
    }
}
