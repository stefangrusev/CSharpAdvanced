using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] carProps = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Car car = new Car
                    (
                    carProps[0],
                    int.Parse(carProps[1]),
                    int.Parse(carProps[2]),
                    int.Parse(carProps[3]),
                    carProps[4],
                    double.Parse(carProps[5]),
                    int.Parse(carProps[6]),
                    double.Parse(carProps[7]),
                    int.Parse(carProps[8]),
                    double.Parse(carProps[9]),
                    int.Parse(carProps[10]),
                    double.Parse(carProps[11]),
                    int.Parse(carProps[12]));

                cars.Add(car);

            }

            string command = Console.ReadLine();
            string[] carModels;
            if (command == "fragile")
            {
                carModels = cars
                    .Where(c => c.Cargo.Type == "fragile" && c.Tires.Any(c => c.Pressure < 1))
                    .Select(c => c.Model)
                    .ToArray();
            }
            else
            {
                carModels = cars
                    .Where(c => c.Cargo.Type == "flammable" && c.Engine.Power > 250)
                    .Select(c => c.Model)
                    .ToArray();
            }

            foreach (var carModel in carModels)
            {
                Console.WriteLine(carModel);
            }
        }
    }
}
