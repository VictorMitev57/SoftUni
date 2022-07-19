
using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer1
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }


        public void Drive(double distance)
        {
            double consumption = distance * this.FuelConsumption;
            if (this.FuelQuantity - consumption > 0)
            {
                FuelQuantity = this.FuelQuantity - consumption;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI() 
        {
            string carInfo = 
                 $"Make: {this.Make}\r\n" +
                 $"Model: {this.Model}\r\n" +
                 $"Year: {this.Year}\r\n" +
                 $"Fuel: {this.FuelQuantity:f2}";

            return carInfo;
        }

        public Car() 
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            this.FuelQuantity = 200;
            this.FuelConsumption = 10;

        }

        public Car(string make, string model, int year ) : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public Engine Engine { get; set; }
        public Tire[] Tires { get; set; }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires): 
            this(make, model, year, fuelQuantity, fuelConsumption)
        {
            this.Engine = engine;
            this.Tires = tires;
        }
    }
}
