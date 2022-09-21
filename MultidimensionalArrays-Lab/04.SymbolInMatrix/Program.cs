using System;

namespace _04.SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsAndColsOfTheMatrix = int.Parse(Console.ReadLine());
            char[,] matrix = new char[rowsAndColsOfTheMatrix, rowsAndColsOfTheMatrix];

            for (int row = 0; row < rowsAndColsOfTheMatrix; row++)
            {
                string input = Console.ReadLine();

                for (int column = 0; column < rowsAndColsOfTheMatrix; column++)
                {
                    matrix[row, column] = input[column];
                }
            }


            char symbolToMatch = char.Parse(Console.ReadLine());

            for (int row = 0; row < rowsAndColsOfTheMatrix; row++)
            {
                for (int column = 0; column < rowsAndColsOfTheMatrix; column++)
                {
                    if (matrix[row, column] == symbolToMatch)
                    {
                        Console.WriteLine($"({row}, {column})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{symbolToMatch} does not occur in the matrix");
        }
    }
}
