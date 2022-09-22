using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace _01.CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            double[] numbers = ConsoleInput();

            Dictionary<double, int> occurances = new Dictionary<double, int>();

            foreach (double number in numbers)
            {
                if (!occurances.ContainsKey(number))
                {
                    occurances.Add(number, 0);
                }

                occurances[number]++;
            }

            foreach (KeyValuePair<double, int> occurance in occurances)
            {
                Console.WriteLine($"{occurance.Key} - {occurance.Value} times");
            }
        }

        private static double[] ConsoleInput()
        {
            return
                Console.ReadLine()
                .Split(' ')
                .Select(n => double.Parse(n))
                .ToArray();
        }
    }
}
