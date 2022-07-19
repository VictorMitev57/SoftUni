using CarManufacturer1;
using System;

namespace CarManufacturer1
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantity = int.Parse(Console.ReadLine());
            double fuelConsumption = int.Parse(Console.ReadLine());

            Car firstCar = new Car();
            Car secondCar = new Car(make, model, year);
            Car thirdCar = new Car(make, model, year, fuelQuantity, fuelConsumption);

            var engine = new Engine(560, 6300); 

            var tires = new Tire[4];
            {
                new Tire(1, 2.5);
                new Tire(1, 2.1);
                new Tire(2, 0.5);
                new Tire(2, 2.3);
            };


            var car = new Car("Lamborghini", "Urus", 2010, 250, 9, engine, tires);
        }
    }
}
