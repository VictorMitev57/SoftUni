using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        const double CoffeeMilliliters = 50;
        const decimal CoffeePrice = 3.50m;

        public double Caffeine { get; set; }

        public Coffee(string name, double caffeine) 
            : base(name, CoffeePrice, CoffeeMilliliters)
        {
            this.Caffeine = caffeine;
        }
    }
}
