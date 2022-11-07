using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> seqOfMgCaffeine = new Stack<int>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            Queue<int> seqOfEnergyDrinks = new Queue<int>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));


            int totallCaffeine = 0;

            while (seqOfMgCaffeine.Any() && seqOfEnergyDrinks.Any())
            {
                var currentCaffeine = seqOfMgCaffeine.Peek() * seqOfEnergyDrinks.Peek();
                if (totallCaffeine + currentCaffeine <= 300)
                {
                    totallCaffeine += currentCaffeine;
                    seqOfEnergyDrinks.Dequeue();
                    seqOfMgCaffeine.Pop();
                }
                else
                {
                    seqOfMgCaffeine.Pop();
                    seqOfEnergyDrinks.Enqueue(seqOfEnergyDrinks.Dequeue());
                    totallCaffeine -= 30;
                    totallCaffeine = totallCaffeine < 0 ? 0 : totallCaffeine;
                }
            }

            Console.WriteLine(seqOfEnergyDrinks.Any() ? 
                              $"Drinks left: {String.Join(", ", seqOfEnergyDrinks)}"
                              : "At least Stamat wasn't exceeding the maximum caffeine.");

            Console.WriteLine($"Stamat is going to sleep with {totallCaffeine} mg caffeine.");

        }
    }
}
