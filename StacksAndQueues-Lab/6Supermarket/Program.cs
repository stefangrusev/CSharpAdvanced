using System;
using System.Collections.Generic;

namespace _6Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            while (true)
            {
                string name = Console.ReadLine();
                if (name == "Paid")
                {
                    Console.WriteLine(string.Join(Environment.NewLine, queue));
                    queue.Clear();
                }
                else if (name == "End")
                {
                    Console.WriteLine($"{queue.Count} people remaining.");
                    break;
                }
                else queue.Enqueue(name);
            }
        }
    }
}
