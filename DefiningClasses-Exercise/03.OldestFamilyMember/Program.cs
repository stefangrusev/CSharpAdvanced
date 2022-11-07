using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int membersCount = int.Parse(Console.ReadLine());
            Family members = new Family();

            for (int i = 0; i < membersCount; i++)
            {
                string[] membersNameAge = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries);

                string name = membersNameAge[0];
                int age = int.Parse(membersNameAge[1]);

                members.AddMember(new Person(name, age));
            }

            Console.WriteLine($"{members.GetTheOldestMember().Name} {members.GetTheOldestMember().Age}");

        }
    }
}
