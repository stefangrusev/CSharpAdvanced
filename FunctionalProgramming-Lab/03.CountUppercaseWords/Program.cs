using System;
using System.Linq;

namespace _03.CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> isUpperCapital = w => char.IsUpper(w[0]);
            Console.WriteLine(string.Join(Environment.NewLine, Array
                .FindAll(Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries), isUpperCapital)));
        }
    }
}
