using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LargestThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = ConsoleInput();
            numbers = numbers
                .OrderByDescending(x => x)
                .Take(3)
                .ToList();
            Console.WriteLine(String.Join(" ", numbers));
        }


        private static List<int> ConsoleInput()
        {
            return
                Console.ReadLine()
                .Split()
                .Select(n => int.Parse(n))
                .ToList();
        }
    }
}
