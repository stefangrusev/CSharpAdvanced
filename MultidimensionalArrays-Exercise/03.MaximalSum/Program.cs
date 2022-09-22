using System;
using System.Linq;

namespace _03.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixDimension = MatrixParameters();
            int[,] matrix = new int[matrixDimension[0], matrixDimension[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = MatrixParameters();
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    matrix[row, column] = input[column];
                }
            }

            int maxSum = int.MinValue;
            int maxRow = int.MinValue;
            int maxCol = int.MinValue;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                int sum = 0;
                for (int column = 0; column < matrix.GetLength(1) - 2; column++)
                {
                    sum =
                        matrix[row, column] +
                        matrix[row, column + 1] +
                        matrix[row, column + 2] +
                        matrix[row + 1, column] +
                        matrix[row + 1, column + 1] +
                        matrix[row + 1, column + 2] +
                        matrix[row + 2, column] +
                        matrix[row + 2, column + 1] +
                        matrix[row + 2, column + 2];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxRow = row;
                        maxCol = column;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine($"{matrix[maxRow, maxCol]} {matrix[maxRow, maxCol + 1]} {matrix[maxRow, maxCol + 2]}");
            Console.WriteLine($"{matrix[maxRow + 1, maxCol]} {matrix[maxRow + 1, maxCol + 1]} {matrix[maxRow + 1, maxCol + 2]}");
            Console.WriteLine($"{matrix[maxRow + 2, maxCol]} {matrix[maxRow + 2, maxCol + 1]} {matrix[maxRow + 2, maxCol + 2]}");

        }


        private static int[] MatrixParameters()
        {
            return
                Console.ReadLine()
                .Split(new string[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToArray();
        }
    }
}
