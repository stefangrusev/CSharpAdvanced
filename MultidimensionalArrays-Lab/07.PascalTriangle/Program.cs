using System;

namespace _07.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            long[][] jagged = new long[rows][];

            for (int row = 0; row < rows; row++)
            {
                jagged[row] = new long[row + 1];
                jagged[row][0] = 1;
                jagged[row][jagged[row].Length - 1] = 1;

                for (int column = 1; column < row; column++)
                {
                    jagged[row][column] = jagged[row - 1][column] + jagged[row - 1][column - 1];
                }
            }

            foreach (long[] item in jagged)
            {
                Console.WriteLine(String.Join(" ", item));
            }
        }
    }
}
