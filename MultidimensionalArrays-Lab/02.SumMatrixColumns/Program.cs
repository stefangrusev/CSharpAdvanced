using System;

namespace _02.SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] matrixDimension = inputReading();

            int rows = int.Parse(matrixDimension[0]);
            int columns = int.Parse(matrixDimension[1]);

            int[,] matrix = new int[rows, columns];

            for (int row = 0; row < rows; row++)
            {
                string[] rowData = inputReading();

                for (int column = 0; column < columns; column++)
                {
                    matrix[row, column] = int.Parse(rowData[column]);
                }
            }


            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                int sum = 0;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sum += matrix[row, column];
                }

                Console.WriteLine(sum);
            }
        }

        private static string[] inputReading()
        {
            return Console.ReadLine().Split(", ");
        }
    }
}
