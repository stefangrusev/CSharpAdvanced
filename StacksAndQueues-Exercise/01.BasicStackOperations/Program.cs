using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] stackArgs = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int numberOfElements = stackArgs[0];
            int removedElements = stackArgs[1];
            int elementToLook = stackArgs[2];

            int[] elementToAppend = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(elementToAppend); //elementToAppend is the max capacity of the stack

            for (int i = 0; i < removedElements; i++)
            {
                stack.Pop();
            }


            if (stack.Contains(elementToLook))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine(stack.Count);
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
