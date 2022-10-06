using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;

        public string Make
        {
            get
            {
                return make;
            }
            set
            {
                this.make = value;
            }
        }

        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                this.model = value;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                this.year = value;
            }
        }

        public double FuelQuantity
        {
            get
            {
                return fuelQuantity;
            }
            set
            {
                this.fuelQuantity = value;
            }
        }

        public double FuelConsumption
        {
            get
            {
                return fuelConsumption;
            }
            set
            {
                this.fuelConsumption = value;
            }
        }

        public void Drive(double distance)
        {
            double fuelLeft = fuelQuantity - (distance * FuelConsumption);
            if (fuelLeft < 0)
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
                return;
            }

            fuelQuantity = fuelLeft;
        }

        public string WhoAmI()
        {
            return
                $"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel: {this.FuelQuantity:f2}";
        }
    }
}
