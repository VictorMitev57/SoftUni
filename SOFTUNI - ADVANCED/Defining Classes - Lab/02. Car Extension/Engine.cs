using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer1
{
    public class Engine
    {
        private int horsePower;
        private double cubicCapacity;

        public int HorsePower { get; set; }
        public double CubicCapacity { get; set; }

        public Engine(int horsePower, double cubicCapacity) 
        {
            this.HorsePower = horsePower;
            this.CubicCapacity = cubicCapacity;
        }
    }
}
