﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class Tire
    {
        private int year;
        private double pressure;


        public Tire(int year, double pressure)
        {
            this.Year = year;
            this.Pressure = pressure;
        }


        public int Year { get { return year; } set { this.year = value; } }
        public double Pressure { get { return pressure; } set { this.pressure = value; } }
    }
}
