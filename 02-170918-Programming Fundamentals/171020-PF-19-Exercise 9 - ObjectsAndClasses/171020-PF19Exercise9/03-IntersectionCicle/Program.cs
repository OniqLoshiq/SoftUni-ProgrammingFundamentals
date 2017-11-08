using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_IntersectionCicle
{
    class Circle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int R { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = GetCircle();
            Circle c2 = GetCircle();

            double distance = GetDistanceBtwnCircles(c1, c2);

            string output = distance <= (c1.R + c2.R) ? "Yes" : "No";

            Console.WriteLine(output);
        }

        static Circle GetCircle()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Circle circle = new Circle { X = input[0], Y = input[1], R = input[2] };
            return circle;
        }

        static double GetDistanceBtwnCircles(Circle c1, Circle c2)
        {
            double distanceBtwnCircles = Math.Sqrt((Math.Pow((c1.X - c2.X), 2)) + (Math.Pow((c1.Y - c2.Y), 2)));
            return distanceBtwnCircles;
        }
    }
}
