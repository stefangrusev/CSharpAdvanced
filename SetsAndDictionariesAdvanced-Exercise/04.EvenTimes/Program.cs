using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfIntegers = Input();
            Dictionary<int, int> ints = new Dictionary<int, int>();

            for (int i = 0; i < countOfIntegers; i++)
            {
                int integer = IntegerReading();
                if (!ints.ContainsKey(integer)) 
                {
                    ints.Add(integer, 0);
                }
                ints[integer]++;
            }

            Console.WriteLine(ints.Single(x => x.Value % 2 == 0).Key);

        }

        private static int IntegerReading()
        {
            return int.Parse(Console.ReadLine());
        }

        private static int Input()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}
