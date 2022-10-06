﻿using System;
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
        private Engine engine;
        private Tire[] tires;


        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
        }
        public Car(string make, string model, int year)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
            : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)
            : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            this.Engine = engine;
            this.Tires = tires;
        }


        public string Make { get { return make; } set { this.make = value; } }
        public string Model { get { return model; } set { this.model = value; } }
        public int Year { get { return year; } set { this.year = value; } }
        public double FuelQuantity { get { return fuelQuantity; } set { this.fuelQuantity = value; } }
        public double FuelConsumption { get { return fuelConsumption; } set { this.fuelConsumption = value; } }
        public Engine Engine { get { return engine; } set { this.engine = value; } }
        public Tire[] Tires { get { return tires; } set { this.tires = value; } }


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


