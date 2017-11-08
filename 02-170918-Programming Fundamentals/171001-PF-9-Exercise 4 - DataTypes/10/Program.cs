using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());

            ushort years = (ushort)(centuries * 100);
            uint days = (uint)(years * 365.2422);
            uint hours = days * 24;
            uint minutes = hours * 60;
            ulong seconds = (ulong)minutes * 60;
            ulong milliseconds = (seconds * 1000);
            ulong microseconds = (milliseconds * 1000);
            BigInteger nanoseconds = (BigInteger)microseconds * 1000;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = " +
                $"{seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
