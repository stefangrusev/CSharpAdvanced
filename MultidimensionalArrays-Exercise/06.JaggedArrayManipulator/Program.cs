using System;
using System.Linq;

namespace _06.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            byte rows = byte.Parse(Console.ReadLine());
            double[][] jagged = new double[rows][];

            for (int row = 0; row < rows; row++)
            {
                double[] input = ConsoleInput();
                jagged[row] = input;
            }

            for (int row = 0; row <= rows - 2; row++)
            {
                if (jagged[row].Length == jagged[row + 1].Length)
                {
                    jagged[row] = jagged[row].Select(x => x * 2).ToArray();
                    jagged[row + 1] = jagged[row + 1].Select(x => x * 2).ToArray();
                }

                else
                {
                    jagged[row] = jagged[row].Select(x => x / 2).ToArray();
                    jagged[row + 1] = jagged[row + 1].Select(x => x / 2).ToArray();
                }
            }


            string command = Console.ReadLine()?.ToUpper();
            while (command != "END")
            {
                string[] commandArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int row = int.Parse(commandArgs[1]);
                int column = int.Parse(commandArgs[2]);
                double value = double.Parse(commandArgs[3]);

                if (row < 0 || row >= rows || column < 0 || column >= jagged[row].Length)
                {
                    command = Console.ReadLine()?.ToUpper();
                    continue;
                }
                else if (commandArgs[0] == "ADD")
                {
                    jagged[row][column] += value;
                }
                else if (commandArgs[0] == "SUBTRACT")
                {
                    jagged[row][column] -= value;
                }
                command = Console.ReadLine()?.ToUpper();
            }


            foreach (var item in jagged)
            {
                Console.WriteLine(String.Join(" ", item));
            }


        }
        private static double[] ConsoleInput()
        {
            return Console.ReadLine()
                .Split(new string[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
        }
    }
}
