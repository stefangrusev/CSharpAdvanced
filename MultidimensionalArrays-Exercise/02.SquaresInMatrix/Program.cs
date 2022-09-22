using System;
using System.Linq;

namespace _02.SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixDimensions = ConsoleReading();
            int rows = matrixDimensions[0];
            int columns = matrixDimensions[1];

            string[,] matrix = new string[rows, columns];

            for (int row = 0; row < rows; row++)
            {
                string[] @char = Console.ReadLine()
                    .Split(' ');

                for (int column = 0; column < columns; column++)
                {
                    matrix[row, column] = @char[column];
                }
            }

            int square = 0;
            for (int row = 0; row < rows - 1; row++)
            {
                for (int column = 0; column < columns - 1; column++)
                {
                    if (matrix[row, column] == matrix[row + 1, column] &&
                        matrix[row, column] == matrix[row, column + 1] &&
                        matrix[row, column] == matrix[row + 1, column + 1])
                    {
                        square++;
                    }
                }
            }

            Console.WriteLine(square);

        }


        private static int[] ConsoleReading()
        {
            return
                Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToArray();
        }
    }
}
