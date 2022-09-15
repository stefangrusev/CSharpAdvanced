using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int racks = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>(clothes);

            int sum = 0;
            int necessaryRacksMore = 1;

            while (stack.Any())
            {
                Checks(racks, stack, ref sum, ref necessaryRacksMore);
            }

            Console.WriteLine(necessaryRacksMore);
        }



        private static void Checks(int racks, Stack<int> stack, ref int sum, ref int necessaryRacksMore)
        {
            if (sum + stack.Peek() < racks)
            {
                sum += stack.Pop();
            }

            else if (sum + stack.Peek() == racks)
            {
                sum += stack.Pop();
                sum = 0;
                if (stack.Count > 0)
                {
                    necessaryRacksMore++;
                }
            }

            else if (sum + stack.Peek() > racks)
            {
                sum = 0;
                sum += stack.Pop();
                necessaryRacksMore++;
            }
        }
    }
}
