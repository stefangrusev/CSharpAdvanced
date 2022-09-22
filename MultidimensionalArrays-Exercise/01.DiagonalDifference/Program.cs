using System;
using System.Linq;

namespace _01.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizePerSquare = int.Parse(Console.ReadLine());

            int[,] matrix = new int[sizePerSquare, sizePerSquare];


            for (int row = 0; row < sizePerSquare; row++)
            {
                int[] valueOfTheRow = ReadingFromConsole();
                for (int column = 0; column < sizePerSquare; column++)
                {
                    matrix[row, column] = valueOfTheRow[column];
                }
            }


            int sum1 = 0;
            for (int i = 0; i < sizePerSquare; i++)
            {
                sum1 += matrix[i, i];
            }

            int sum2 = 0;
            int j = 0;
            for (int i = sizePerSquare-1; i >= 0; i--)
            {
                sum2 += matrix[j, i];
                j++;
            }

            Console.WriteLine(Math.Abs(sum1-sum2));

        }


        private static int[] ReadingFromConsole()
        {
            return
                Console.ReadLine()
                .Split(' ')
                .Select(n => int.Parse(n))
                .ToArray();
        }
    }
}
