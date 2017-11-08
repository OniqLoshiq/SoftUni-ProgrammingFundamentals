using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Debug_InstructionSet
{
    class Program
    {
        static void Main(string[] args)
        {
            string opCode = Console.ReadLine();

            long result = 0;

            while (opCode != "END")
            {
                string[] codeArgs = opCode.Split(' ');

               
                switch (codeArgs[0])
                {
                    case "INC":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            result = ++operandOne;

                            break;
                        }
                    case "DEC":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            result = --operandOne;

                            break;
                        }
                    case "ADD":
                        {
                            int operandOne = int.Parse(codeArgs[1]);
                            int operandTwo = int.Parse(codeArgs[2]);
                            result = (long)operandOne + operandTwo;

                            break;
                        }
                    case "MLA":
                        {
                            int operandOne = int.Parse(codeArgs[1]);
                            int operandTwo = int.Parse(codeArgs[2]);
                            result = (long)(operandOne) * operandTwo;

                            break;
                        }
                }
                Console.WriteLine(result);
                opCode = Console.ReadLine();
            }
           
        }
    }
}
