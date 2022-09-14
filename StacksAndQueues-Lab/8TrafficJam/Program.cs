using System;
using System.Collections;
using System.Collections.Generic;

namespace _8TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            string inputCommand = Console.ReadLine();
            int counter = 0;

            while (inputCommand != "end")
            {
                if (inputCommand != "green")
                {
                    cars.Enqueue(inputCommand);
                    inputCommand = Console.ReadLine();
                }
                else
                {
                    var count = cars.Count;
                    for (int i = 0; i < (count < greenLight ? count : greenLight); i++)
                    {
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                        counter++;
                    }
                    inputCommand = Console.ReadLine();
                    continue;
                }
            }
            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
