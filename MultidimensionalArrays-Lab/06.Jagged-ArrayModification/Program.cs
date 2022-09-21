using System;
using System.Linq;

namespace _06.Jagged_ArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArr = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                jaggedArr[row] = ConsoleInput();
            }

            string[] command = Console.ReadLine().Split();

            while (command[0] != "END")
            {
                switch (command[0])
                {
                    case "Add":
                        int row = int.Parse(command[1]);
                        int column = int.Parse(command[2]);
                        int add = int.Parse(command[3]);

                        if (row >= 0 && row < jaggedArr.Length && column >= 0 && column < jaggedArr[row].Length)
                        {
                            jaggedArr[row][column] += add;
                        }
                        else
                        {
                            Console.WriteLine("Invalid coordinates");
                        }
                        break;


                    case "Subtract":
                        row = int.Parse(command[1]);
                        column = int.Parse(command[2]);
                        int sub = int.Parse(command[3]);

                        if (row >= 0 && row < jaggedArr.Length && column >= 0 && column < jaggedArr[row].Length)
                        {
                            jaggedArr[row][column] -= sub;
                        }
                        else
                        {
                            Console.WriteLine("Invalid coordinates");
                        }
                        break;
                }

                command = Console.ReadLine().Split();
            }


            for (int row = 0; row < jaggedArr.Length; row++)
            {
                Console.WriteLine(String.Join(" ", jaggedArr[row]));
            }

        }


        private static int[] ConsoleInput()
        {
            return
                Console.ReadLine()
                    .Split()
                    .Select(n => int.Parse(n))
                    .ToArray();
        }
    }
}
