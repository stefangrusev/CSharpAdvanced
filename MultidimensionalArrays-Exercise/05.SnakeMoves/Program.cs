using System;
using System.Linq;

namespace _05.SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] matrixDimensions = MatrixParameters();
            string snakeName = Console.ReadLine();

            string[][] snakeWay = new string[matrixDimensions[0]][];
            string temp = snakeName;

            for (int row = 0; row < snakeWay.GetLength(0); row++)
            {
                snakeWay[row] = new string[matrixDimensions[1]];

                switch (row % 2)
                {
                    case 0:
                        {
                            for (int column = 0; column < matrixDimensions[1]; column++)
                            {
                                if (snakeName.Length == 0)
                                {
                                    snakeName += temp;
                                }
                                snakeWay[row][column] = snakeName[0].ToString();
                                snakeName = snakeName.Remove(0, 1);
                            }
                            break;
                        }

                    default:
                        {
                            for (int column = matrixDimensions[1] - 1; column >= 0; column--)
                            {
                                if (snakeName.Length == 0)
                                {
                                    snakeName += temp;
                                }
                                snakeWay[row][column] = snakeName[0].ToString();
                                snakeName = snakeName.Remove(0, 1);
                            }
                            break;
                        }
                }
            }


            foreach (var item in snakeWay)
            {
                Console.WriteLine(String.Join("", item));
            }

        }


        private static byte[] MatrixParameters()
        {
            return
                Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(n => byte.Parse(n))
                .ToArray();
        }
    }
}
