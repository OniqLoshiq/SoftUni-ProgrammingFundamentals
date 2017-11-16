using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Ladybug
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            List<int> field = new List<int>(new int[fieldSize]);
            int[] bugsPosition = Console.ReadLine().Split().Select(int.Parse).Distinct().ToArray();

            for (int i = 0; i < bugsPosition.Length; i++)
            {
                if (bugsPosition[i] < 0 || bugsPosition[i] > field.Count - 1)
                {
                    continue;
                }
                field[bugsPosition[i]] = 1;
            }

            while (true)
            {
                string[] cmdArgs = Console.ReadLine().Split();
                if (cmdArgs[0] == "end")
                {
                    break;
                }

                int index = int.Parse(cmdArgs[0]);
                string cmd = cmdArgs[1];
                int movement = int.Parse(cmdArgs[2]);

                if (index < 0 || index > field.Count - 1 || movement == 0 || field[index] == 0)
                {
                    continue;
                }

                if ((cmd == "right" && movement > 0) || (cmd == "left" && movement < 0))
                {
                    MoveToRight(field, index, movement);
                }
                else if ((cmd == "left" && movement > 0) || (cmd == "right" && movement < 0))
                {
                    MoveToLeft(field, index, movement);
                }
            }

            Console.WriteLine(string.Join(" ", field));
        }

        private static void MoveToLeft(List<int> field, int index, int movement)
        {
            movement = Math.Abs(movement);
            field[index] = 0;

            if (index - movement >= 0)
            {
                int tryouts = index / movement;

                for (int i = 1; i <= tryouts; i++)
                {
                    if (field[index - movement * i] == 0)
                    {
                        field[index - movement * i] = 1;
                        break;
                    }
                }
            }
        }

        private static void MoveToRight(List<int> field, int index, int movement)
        {
            movement = Math.Abs(movement);
            field[index] = 0;

            if (index + movement <= field.Count - 1)
            {
                int tryouts = (field.Count - 1 - index) / movement;
                for (int i = 1; i <= tryouts; i++)
                {
                    if (field[index + movement * i] == 0)
                    {
                        field[index + movement * i] = 1;
                        break;
                    }
                }
            }
        }
    }
}
