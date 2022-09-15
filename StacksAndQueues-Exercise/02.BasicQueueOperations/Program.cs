using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] queueArgs = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int numberOfElements = queueArgs[0];
            int removedElements = queueArgs[1];
            int elementToLook = queueArgs[2];

            int[] elementToAppend = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(elementToAppend);

            for (int i = 0; i < removedElements; i++)
            {
                queue.Dequeue();
            }


            if (queue.Contains(elementToLook))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count == 0)
            {
                Console.WriteLine(queue.Count);
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
