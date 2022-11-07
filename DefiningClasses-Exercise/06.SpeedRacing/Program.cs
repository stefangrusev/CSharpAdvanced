using System;
using System.Collections.Generic;

namespace _06.SpeedRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = carInfo[0];
                double fuelAmount = double.Parse(carInfo[1]);
                double fuelPerKm = double.Parse(carInfo[2]);

                cars.Add(new Car(model, fuelAmount, fuelPerKm));
            }


            string[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "End")
            {
                if (command[0] == "Drive")
                {
                    string model = command[1];
                    Car currentCar = cars.Find(c => c.Model.Equals(model));
                    double distance = double.Parse(command[2]);
                    currentCar.CarToMoveOrNot(distance);
                }

                command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            cars.ForEach(car => Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}"));

        }
    }
}
