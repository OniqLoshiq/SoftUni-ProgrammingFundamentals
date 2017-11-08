using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Star
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int healthCur = int.Parse(Console.ReadLine());
            int healthMax = int.Parse(Console.ReadLine());
            int energyCur = int.Parse(Console.ReadLine());
            int energyMax = int.Parse(Console.ReadLine());

            int healthMissing = healthMax - healthCur;
            int energyMissing = energyMax - energyCur;

            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Health: |{0}{1}|", new string ('|', healthCur), new string ('.', healthMissing));
            Console.WriteLine("Energy: |{0}{1}|", new string ('|', energyCur), new string ('.', energyMissing));
        }
    }
}
