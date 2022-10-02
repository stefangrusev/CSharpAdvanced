using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(" ").ToList();
            Action<string> printSirBeforeNames = name => Console.WriteLine($"Sir {name}");
            names.ForEach(printSirBeforeNames);
        }
    }
}
