﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximumАндMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] query = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                switch (query[0])
                {
                    case 1:
                        stack.Push(query[1]);
                        break;

                    case 2:
                        if (stack.Count != 0)
                        {
                            stack.Pop();
                        }
                        break;

                    case 3:
                        if (stack.Count != 0)
                        {
                            Console.WriteLine(stack.Max());
                        }
                        break;

                    case 4:
                        if (stack.Count != 0)
                        {
                            Console.WriteLine(stack.Min());
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
