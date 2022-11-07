using System;
using System.Collections.Generic;
using System.Text;

namespace _06.SpeedRacing
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelPerKm;
        private double travelledDistance;


        public Car(string model, double fuelAmount, double fuelPerKm)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelPerKm = fuelPerKm;
        }


        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public double FuelAmount
        {
            get { return this.fuelAmount; }
            set { this.fuelAmount = value; }
        }
        public double FuelPerKm
        {
            get { return this.fuelPerKm; }
            set { this.fuelPerKm = value; }
        }
        public double TravelledDistance { get; set; } = 0;


        public void CarToMoveOrNot(double distance)
        {
            bool isEnough = FuelAmount - FuelPerKm * distance >= 0;
            if (isEnough)
            {
                FuelAmount -= FuelPerKm * distance;
                TravelledDistance += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
