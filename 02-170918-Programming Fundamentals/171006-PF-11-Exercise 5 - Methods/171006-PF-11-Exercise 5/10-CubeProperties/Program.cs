using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            string cubeProperties = Console.ReadLine();

            if (cubeProperties == "face") Console.WriteLine($"{GetLengthFaceDiagonals(n):f2}");
            else if (cubeProperties == "space") Console.WriteLine($"{GetLengthSpaceDiagonals(n):f2}");
            else if (cubeProperties == "volume") Console.WriteLine($"{GetVolume(n):f2}");
            else if (cubeProperties == "area") Console.WriteLine($"{GetArea(n):f2}");
        }

        static double GetLengthFaceDiagonals(double n)
        {
            return Math.Sqrt(2 * n * n);
        }
        static double GetLengthSpaceDiagonals(double n)
        {
            return Math.Sqrt(3 * n * n);
        }
        static double GetVolume(double n)
        {
            return Math.Pow(n, 3);
        }
        static double GetArea(double n)
        {
            return 6 * n * n;
        }
    }
}
