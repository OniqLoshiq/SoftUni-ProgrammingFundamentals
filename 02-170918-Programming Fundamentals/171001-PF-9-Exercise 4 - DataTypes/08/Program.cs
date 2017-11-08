using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            ulong numID = ulong.Parse(Console.ReadLine());
            uint numEmpl = uint.Parse(Console.ReadLine());

            Console.WriteLine($"First name: {firstName}{Environment.NewLine}Last name: {secondName}{Environment.NewLine}" +
                $"Age: {age}{Environment.NewLine}Gender: {gender}{Environment.NewLine}Personal ID: {numID}{Environment.NewLine}" +
                $"Unique Employee number: {numEmpl}");
        }
    }
}
