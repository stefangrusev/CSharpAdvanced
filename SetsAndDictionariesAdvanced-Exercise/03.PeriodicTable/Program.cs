using System;
using System.Collections.Generic;

namespace _03.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfInputRows = InputLines();

            SortedSet<string> chemicalCompounds = new SortedSet<string>();

            for (int i = 0; i < countOfInputRows; i++)
            {
                string[] chemicalElements = ConsoleInput();
                chemicalCompounds.UnionWith(chemicalElements);
            }

            Console.WriteLine(String.Join(" ", chemicalCompounds));

        }

        private static string[] ConsoleInput()
        {
            return Console.ReadLine().Split();
        }

        private static int InputLines()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}
