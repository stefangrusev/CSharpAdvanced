using System;
using System.Linq;

namespace _04.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixDimensions = MatrixParameters();
            string[,] matrix = new string[matrixDimensions[0], matrixDimensions[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    matrix[row, column] = input[column];
                }
            }


            string cmd = Console.ReadLine()?.ToUpper();
            while (cmd != "END")
            {
                string[] cmdArgs = cmd.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (cmdArgs[0] != "SWAP" || cmdArgs.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                    cmd = Console.ReadLine()?.ToUpper();
                    continue;
                }

                int firstRow = int.Parse(cmdArgs[1]);
                int firstCol = int.Parse(cmdArgs[2]);
                int secondRow = int.Parse(cmdArgs[3]);
                int secondCol = int.Parse(cmdArgs[4]);


                if (firstRow < 0 || firstRow >= matrixDimensions[0]
                    || firstCol < 0 || firstCol >= matrixDimensions[1]
                    || secondRow < 0 || secondRow >= matrixDimensions[0]
                    || secondCol < 0 || secondCol >= matrixDimensions[1])
                {
                    Console.WriteLine("Invalid input!");
                    cmd = Console.ReadLine()?.ToUpper();
                    continue;
                }

                string temp = matrix[firstRow, firstCol];

                matrix[firstRow, firstCol] = matrix[secondRow, secondCol];
                matrix[secondRow, secondCol] = temp;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int column = 0; column < matrix.GetLength(1); column++)
                    {
                        Console.Write($"{matrix[row, column]} ");
                    }

                    Console.WriteLine();
                }

                cmd = Console.ReadLine()?.ToUpper();

            }
        }


        private static int[] MatrixParameters()
        {
            return Console.ReadLine()
                .Split(new string[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
