using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());
            Queue<int> queue = new Queue<int>(Console.ReadLine().Split(' ').Select(int.Parse));
            Console.WriteLine(queue.Max());

            int qCount = queue.Count;
            for (int i = 0; i < qCount; i++)
            {
                if (food >= queue.Peek())
                {
                    food -= queue.Peek();
                    queue.Dequeue();
                }
                else
                {
                    break;
                }
            }

            Output(queue);
        }



        private static void Output(Queue<int> queue)
        {
            if (queue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
            }
        }
    }
}
