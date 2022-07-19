using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        const double DefaultFuelConsumption = 1.25;

        private double fuel;
        private int horsePoweR;
        private virtual double fuelConsumption;

        public int HorsePower { get; set; }
        public double Fuel { get; set; }
        public double FuelConsumption { get; set; }

        public Vehicle(int horsePower, double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
            this.FuelConsumption = fuelConsumption; 
        }

        public virtual void Drive(double kilometers)
        {
            fuelConsumption -= kilometers;
        }
    }
}
