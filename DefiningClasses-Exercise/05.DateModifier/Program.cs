using System;

namespace _05.DateModifier
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();
            int diff = DateModifier.DateDiff(firstDate, secondDate);
            Console.WriteLine(diff);
        }
    }
}
