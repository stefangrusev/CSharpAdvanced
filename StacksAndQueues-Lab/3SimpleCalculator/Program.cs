using System;
using System.Collections.Generic;
using System.Linq;

namespace _3SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string characters = Console.ReadLine();
            List<string> operations = new List<string>();

            foreach (char @char in characters)
            {
                switch (@char)
                {
                    case '+':
                        operations.Add("add");
                        break;
                    case '-':
                        operations.Add("substract");
                        break;
                }
            }

            Stack<int> stack = new Stack<int>(characters.Split(new char[] { ' ', '+', '-' }, StringSplitOptions.RemoveEmptyEntries)
                                                        .Select(int.Parse));
            stack = new Stack<int>(stack);
            int sum = stack.Pop();

            for (int i = 0; i < operations.Count; i++)
            {
                switch (operations[i])
                {
                    case "add":
                        sum += stack.Pop();
                        break;
                    case "substract":
                        sum -= stack.Pop();
                        break;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
