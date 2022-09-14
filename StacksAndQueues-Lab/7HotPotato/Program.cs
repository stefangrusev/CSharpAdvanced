using System;
using System.Collections.Generic;

namespace _7HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> players = new Queue<string>(Console.ReadLine().Split());
            int throwlings = int.Parse(Console.ReadLine());

            while (players.Count > 1)
            {
                for (int i = 1; i < throwlings; i++)
                {
                    players.Enqueue(players.Dequeue());
                }
                Console.WriteLine($"Removed {players.Dequeue()}");
            }
            Console.WriteLine($"Last is {players.Peek()}");
        }
    }
}
