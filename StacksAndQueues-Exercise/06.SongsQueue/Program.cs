using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] startingSongs = Console.ReadLine().Split(", ");
            Queue<string> queueOfTheSongs = new Queue<string>(startingSongs);

            while (queueOfTheSongs.Any()) 
            {
                string[] cmdArgs = Console.ReadLine().Split();
                string cmdType = cmdArgs[0];


                if (cmdType == "Play")
                {
                    queueOfTheSongs.Dequeue();
                }

                else if (cmdType == "Add")
                {
                    string songToAdd = String.Join(" ", cmdArgs.Skip(1));
                    if (queueOfTheSongs.Contains(songToAdd))
                    {
                        Console.WriteLine($"{songToAdd} is already contained!");
                        continue;
                    }
                    queueOfTheSongs.Enqueue(songToAdd);
                }

                else if (cmdType == "Show")
                {
                    Console.WriteLine(String.Join(", ", queueOfTheSongs));
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
