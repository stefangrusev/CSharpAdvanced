using System;
using System.Collections.Generic;
using System.Text;

namespace _09.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> memory = new Stack<string>();
            StringBuilder text = new StringBuilder();
            memory.Push(string.Empty);

            int numberOfOperations = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfOperations; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split();
                string cmdType = cmdArgs[0];


                if (cmdType == "1")
                {
                    string cmdValue = cmdArgs[1];
                    text.Append(cmdValue);
                    memory.Push(text.ToString());
                }
                else if (cmdType == "2")
                {
                    int charsToRemove = int.Parse(cmdArgs[1]);
                    text.Remove(text.Length - charsToRemove, charsToRemove);
                    memory.Push(text.ToString());
                }
                else if (cmdType == "3")
                {
                    int position = int.Parse(cmdArgs[1]);
                    if (position >= 0 && position < text.Length)
                    {
                        Console.WriteLine(text[position-1]);
                    }
                }
                else if (cmdType == "4")
                {
                    memory.Pop();
                    string prevVersion = memory.Peek();

                    text = new StringBuilder(prevVersion);
                }
            }
        }
    }
}
