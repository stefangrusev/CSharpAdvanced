using System;
using System.Collections.Generic;

namespace _01.UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfUsernames = int.Parse(Console.ReadLine());

            HashSet<string> collectionOfUsernames = new HashSet<string>();

            for (int currName = 0; currName < numberOfUsernames; currName++)
            {
                string newOne = Console.ReadLine();
                collectionOfUsernames.Add(newOne);
            }

            foreach (string username in collectionOfUsernames)
            {
                Console.WriteLine(username);
            }
        }
    }
}
