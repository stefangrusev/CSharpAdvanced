using System;
using System.Collections.Generic;
using System.Text;

namespace _07.RawData
{
   public class Car
    {
        public Car
            (
            string model,
            int speed,
            int power,
            int weight,
            string type,
            double tire1pressure,
            int tire1age,
            double tire2pressure,
            int tire2age,
            double tire3pressure,
            int tire3age,
            double tire4pressure,
            int tire4age
            )
        {
            Model = model;
            Engine = new Engine { Power = power, Speed = speed };
            Cargo = new Cargo { Type = type, Weight = weight };
            Tires = new Tire[4];
            Tires[0] = new Tire { Pressure = tire1pressure, Age = tire1age };
            Tires[1] = new Tire { Pressure = tire2pressure, Age = tire2age };
            Tires[2] = new Tire { Pressure = tire3pressure, Age = tire3age };
            Tires[3] = new Tire { Pressure = tire4pressure, Age = tire4age };
        }


        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tire[] Tires { get; set; }
    }
}
