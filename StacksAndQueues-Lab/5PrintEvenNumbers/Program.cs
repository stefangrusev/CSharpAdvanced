using System;
using System.Collections.Generic;
using System.Linq;

namespace _5PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>(Console.ReadLine().Split(' ').Select(int.Parse));
            int queueSum = queue.Sum();
            int sum = 0;
            while (sum != queueSum)
            {
                sum += queue.Peek();
                switch (queue.Peek() % 2)
                {
                    case 1:
                        queue.Dequeue();
                        break;
                    default:
                        queue.Enqueue(queue.Dequeue());
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", queue));
        }
    }
}
