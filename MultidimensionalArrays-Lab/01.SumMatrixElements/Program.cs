using System;
using System.Linq;

namespace _01.SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixDimension = IncomeArray();

            int rows = matrixDimension[0];
            int columns = matrixDimension[1];

            int[,] matrix = new int[rows, columns];

            int sumOfAllElements = 0;

            for (int row = 0; row < rows; row++)
            {
                int[] singleCube = IncomeArray();

                for (int column = 0; column < columns; column++)
                {
                    matrix[row, column] = singleCube[column];
                }

                sumOfAllElements += singleCube.Sum();

            }

            Console.WriteLine($"{rows}{Environment.NewLine}{columns}");
            Console.WriteLine(sumOfAllElements);
          
        }


        static int[] IncomeArray()
        {
            return Console.ReadLine()
                .Split(new string[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToArray();
        }
    }
}
