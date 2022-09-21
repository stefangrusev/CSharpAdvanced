using System;
using System.Linq;

namespace _05.SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixDimension = IncomeArray();

            int rows = matrixDimension[0];
            int columns = matrixDimension[1];

            int[,] matrix = new int[rows, columns];

            for (int row = 0; row < rows; row++)
            {
                int[] element = IncomeArray();
                for (int column = 0; column < columns; column++)
                {
                    matrix[row, column] = element[column];
                }
            }


            long maxSum = long.MinValue;
            string square = string.Empty;

            for (int row = 0; row < rows - 1; row++)
            {
                for (int column = 0; column < columns - 1; column++)
                {
                    long sum =
                        matrix[row, column] +
                        matrix[row, column + 1] +
                        matrix[row + 1, column] +
                        matrix[row + 1, column + 1];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        square =
                        matrix[row, column] + " " + matrix[row, column + 1] + "\r\n" +
                        matrix[row + 1, column] + " " + matrix[row + 1, column + 1];
                    }
                }
            }

            Console.WriteLine(square);
            Console.WriteLine(maxSum);

        }


        private static int[] IncomeArray()
        {
            return
                Console.ReadLine()
                .Split(", ")
                .Select(n => int.Parse(n))
                .ToArray();
        }
    }
}
