using System;

namespace T05SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double coffee = 0;
            double water = 0;
            double beer = 0;
            double sweets = 0;
            double peanuts = 0;
            double price = 0;
            //coffee water   beer sweets  peanuts
            switch (city)
            {
                case "Sofia":
                    coffee = 0.50 ;     /* 0.50    0.80    1.20    1.45    1.60*/
                    water = 0.80;
                    beer = 1.20;
                    sweets = 1.45;
                    peanuts = 1.60;
                    if (product == "coffee")
                    {
                        price = coffee * quantity;
                    }
                    if (product == "water")
                    {
                        price = water * quantity;
                    }
                    if (product == "beer")
                    {
                        price = beer * quantity;
                    }
                    if (product == "sweets")
                    {
                        price = sweets * quantity;
                    }
                    if (product == "peanuts")
                    {
                        price = peanuts * quantity;
                    }
                    break;
                case "Plovdiv":
                     coffee = 0.40;              /* 0.40    0.70    1.15    1.30    1.50*/
                    water = 0.70;
                     beer = 1.15;
                     sweets = 1.30;
                    peanuts = 1.50;
                    if (product == "coffee")
                    {
                        price = coffee * quantity;
                    }
                    if (product == "water")
                    {
                        price = water * quantity;
                    }
                    if (product == "beer")
                    {
                        price = beer * quantity;
                    }
                    if (product == "sweets")
                    {
                        price = sweets * quantity;
                    }
                    if (product == "peanuts")
                    {
                        price = peanuts * quantity;
                    }
                    break;
                case "Varna":                
                     coffee = 0.45;                       /* 0.45   0.70    1.10    1.35    1.55*/
                     water = 0.70;
                     beer = 1.10;
                     sweets = 1.35;
                     peanuts = 1.55;
                     if (product == "coffee")
                    {
                        price = coffee * quantity;
                    }
                    if (product == "water")
                    {
                        price = water * quantity;
                    }
                    if (product == "beer")
                    {
                        price = beer * quantity;
                    }
                    if (product == "sweets")
                    {
                        price = sweets * quantity;
                    }
                    if (product == "peanuts")
                    {
                        price = peanuts * quantity;
                    }
                    break;
            }
            Console.WriteLine(price);
        }
    }
}
