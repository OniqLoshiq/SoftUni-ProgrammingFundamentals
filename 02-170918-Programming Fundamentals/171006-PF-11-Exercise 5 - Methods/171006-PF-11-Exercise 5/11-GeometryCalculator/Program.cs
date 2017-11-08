using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine().ToLower();

            switch (figure)
            {
                case "triangle": GetTriangleArea(); break;
                case "square": GetSquareArea(); break;
                case "rectangle": GetRectangleArea(); break;
                case "circle": GetCircleArea(); break;
            }
        }

        private static void GetCircleArea()
        {
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f2}", Math.PI * radius * radius);
        }

        private static void GetRectangleArea()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f2}", width * height);
        }

        private static void GetSquareArea()
        {
            double side = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f2}", side * side);
        }

        private static void GetTriangleArea()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f2}", side * height / 2);
        }
    }
}
