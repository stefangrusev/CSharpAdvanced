using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();

            foreach (var symbol in input)
            {
                if (stack.Any())
                {
                    char check = stack.Peek();
                    switch (check)
                    {
                        case '{' when symbol == '}':
                            stack.Pop();
                            continue;

                        case '[' when symbol == ']':
                            stack.Pop();
                            continue;

                        case '(' when symbol == ')':
                            stack.Pop();
                            continue;
                    }
                }

                stack.Push(symbol);
            }


            Console.WriteLine(!stack.Any() ? "YES" : "NO");
        }
    }
}
