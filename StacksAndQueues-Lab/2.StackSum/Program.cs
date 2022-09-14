using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(elements);
            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                string[] cmdArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                switch (cmdArgs[0])
                {
                    case "add":
                        {
                            int numbOne = int.Parse(cmdArgs[1]);
                            int numbTwo = int.Parse(cmdArgs[2]);

                            stack.Push(numbOne);
                            stack.Push(numbTwo);
                            break;
                        }
                    case "remove":
                        {
                            int count = int.Parse(cmdArgs[1]);
                            if (stack.Count >= count)
                            {
                                for (int i = 0; i < count; i++)
                                {
                                    stack.Pop();
                                }
                            }
                            break;
                        }
                }

                command = Console.ReadLine().ToLower();
            }

            Console.WriteLine($"Sum: {stack.ToArray().Sum()}");
        }
    }
}
