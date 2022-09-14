using System;
using System.Collections.Generic;

namespace _4MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                char @char = expression[i];
                switch (@char)
                {
                    case '(':
                        stack.Push(i);
                        break;
                    case ')':
                        {
                            int start = stack.Pop();
                            int end = i;
                            string subExpression = expression.Substring(start, end - start + 1);
                            Console.WriteLine(subExpression);
                            break;
                        }
                }
            }
        }
    }
}
