using System;
using System.Collections.Generic;

namespace _05.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = ConsoleReading();
            SortedDictionary<char, int> chars = new SortedDictionary<char, int>();

            foreach (char @char in inputText)
            {
                if (!chars.ContainsKey(@char))
                {
                    chars.Add(@char, 0);
                }
                chars[@char]++;
            }

            foreach (KeyValuePair<char, int> singleChar in chars)
            {
                Console.WriteLine($"{singleChar.Key}: {singleChar.Value} time/s");
            }
        }

        private static string ConsoleReading()
        {
            return Console.ReadLine();
        }
    }
}
