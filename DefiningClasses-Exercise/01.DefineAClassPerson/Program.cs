using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person petar = new Person()
            {
                Name = "Petar",
                Age = 20
            };

            Person george = new Person()
            {
                Name = "George",
                Age = 18
            };

            Person jose = new Person()
            {
                Name = "Jose",
                Age = 43
            };
        }
    }
}
