using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Snowmen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> snowmen = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<bool> activeSnowmen = new List<bool>(new bool[snowmen.Count]);

            while (snowmen.Count > 1)
            {
                for (int i = 0; i < snowmen.Count; i++)
                {
                    int attacker = i;
                    int target = snowmen[i];
                    int falseCounter = activeSnowmen.Where(x => x == false).Count();

                    if(falseCounter == 1)
                    {
                        break;
                    }
                    
                    if(activeSnowmen[i] == true)
                    {
                        continue;
                    }

                    if(target > snowmen.Count - 1)
                    {
                        target = target % snowmen.Count;
                    }

                    int diff = Math.Abs(attacker - target);

                    if (diff == 0)
                    {
                        activeSnowmen[i] = true;
                        Console.WriteLine($"{target} performed harakiri");
                    }
                    else if (diff % 2 == 0)
                    {
                        activeSnowmen[target] = true;
                        Console.WriteLine("{0} x {1} -> {0} wins", attacker, target);
                    }
                    else if (diff % 2 == 1)
                    {
                        activeSnowmen[i] = true;
                        Console.WriteLine("{0} x {1} -> {1} wins", attacker, target);
                    }
                   
                }

                while(activeSnowmen.Contains(true))
                {
                    for (int i = 0; i < snowmen.Count; i++)
                    {
                        if (activeSnowmen[i])
                        {
                            snowmen.RemoveAt(i);
                            activeSnowmen.RemoveAt(i);
                            break;
                        }
                    }
                }
               
            }
        }
    }
}
