using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] setsLength = ConsoleInput();

            int firstSetLength = setsLength[0];
            int secondSetLength = setsLength[1];

            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < firstSetLength + secondSetLength; i++)
            {
                int number = NumberInput();


                if (i <= firstSetLength - 1)
                {
                    firstSet.Add(number);
                }

                else
                {
                    secondSet.Add(number);
                }
            }


            HashSet<int> matchedNumbersSet = new HashSet<int>();

            foreach (int currentNumber in firstSet)
            {
                if (secondSet.Contains(currentNumber))
                {
                    matchedNumbersSet.Add(currentNumber);
                }
            }

            Console.WriteLine($"{String.Join(" ", matchedNumbersSet)}");

        }


        private static int NumberInput()
        {
            return
                int.Parse(Console.ReadLine());
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
