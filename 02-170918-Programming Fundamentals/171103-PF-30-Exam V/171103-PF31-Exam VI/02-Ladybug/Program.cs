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
            List<int> bugs = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < bugs.Count; i++)
            {
                if (bugs[i] > (field.Count - 1))
                {
                    continue;
                }
                field[bugs[i]] = 1;
            }

            while (true)
            {
                string[] cmd = Console.ReadLine().Split();
                if (cmd[0] == "end")
                {
                    break;
                }

                int index = int.Parse(cmd[0]);
                int moveCount = int.Parse(cmd[2]);
                string direction = cmd[1];

                if (index > field.Count - 1 || index < 0 || moveCount == 0)
                {
                    continue;
                }
                if (field[index] == 0)
                {
                    continue;
                }


                MoveBugs(field, index, direction, moveCount);

            }

            Console.WriteLine(string.Join(" ", field));
        }

        private static void MoveBugs(List<int> field, int index, string direction, int moveCount)
        {
            if ((direction == "right" && moveCount > 0) || (direction == "left" && moveCount < 0))
            {
                moveCount = Math.Abs(moveCount);

                if (index + moveCount > field.Count - 1)
                    field[index] = 0;
                else
                {
                    for (int i = 1; i <= ((field.Count - 1 - index) / moveCount); i++)
                    {
                        field[index] = 0;

                        if (field[index + moveCount * i] == 0)
                        {
                            field[index + moveCount * i] = 1;
                            break;
                        }
                    }
                }
            }
            else
            {
                moveCount = Math.Abs(moveCount);


                if (index - moveCount < 0)
                {
                    field[index] = 0;
                }

                else
                {
                    for (int i = 1; i <= index / moveCount; i++)
                    {
                        field[index] = 0;

                        if (field[index - moveCount * i] == 0)
                        {
                            field[index - moveCount * i] = 1;
                            break;
                        }
                    }
                }
            }
        }
    }
}
