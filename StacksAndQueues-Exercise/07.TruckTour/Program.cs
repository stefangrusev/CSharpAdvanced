using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TruckTour
{
    class Pump
    {
        public int amountOfPetrol { get; set; }
        public int distanceBetweenPumps { get; set; }

        public Pump(int amountOfPetrol, int distanceBetweenPumps)
        {
            this.amountOfPetrol = amountOfPetrol;
            this.distanceBetweenPumps = distanceBetweenPumps;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int petrolPumpsValue = int.Parse(Console.ReadLine());
            Queue<int> amountOfPetrol = new Queue<int>();
            Queue<int> distanceBetweenPumps = new Queue<int>();
            int[] input;


            for (int i = 0; i < petrolPumpsValue; i++)
            {
                input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                amountOfPetrol.Enqueue(input[0]);
                distanceBetweenPumps.Enqueue(input[1]);
            }

            int currentFuel;

            Queue<int> petrolCopy = new Queue<int>();
            Queue<int> distanceCopy = new Queue<int>();

            for (int i = 0; i < petrolPumpsValue; i++)
            {
                currentFuel = amountOfPetrol.Peek();
                for (int x = 0; x < petrolPumpsValue; x++)
                {
                    if (distanceBetweenPumps.Peek() <= currentFuel)
                    {
                        currentFuel -= distanceBetweenPumps.Peek();
                        if (x == petrolPumpsValue - 1)
                        {
                            Console.WriteLine(i);
                            return;
                        }
                    }
                    else
                    {
                        for (int y = x; y < petrolPumpsValue; y++)
                        {
                            amountOfPetrol.Enqueue(amountOfPetrol.Dequeue());
                            distanceBetweenPumps.Enqueue(distanceBetweenPumps.Dequeue());
                        }
                        break;
                    }

                    amountOfPetrol.Enqueue(amountOfPetrol.Dequeue());
                    distanceBetweenPumps.Enqueue(distanceBetweenPumps.Dequeue());
                    currentFuel += amountOfPetrol.Peek();
                }

                amountOfPetrol.Enqueue(amountOfPetrol.Dequeue());
                distanceBetweenPumps.Enqueue(distanceBetweenPumps.Dequeue());
            }

        }
    }
}
