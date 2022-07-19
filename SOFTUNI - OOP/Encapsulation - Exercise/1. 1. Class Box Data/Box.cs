using System;
using System.Collections.Generic;
using System.Text;

namespace _1._1._Class_Box_Data
{

    public class Box
    {
        private const int BoxMinValue = 0;

        private double length;
        private double width;
        private double height;

        public double Length
        {
            get { return this.length; }
            private set
            {
                if (value <= BoxMinValue)
                {
                    throw new ArgumentException($"{nameof(this.Length)} cannot be zero or negative.");
                }
                this.length = value;
            }
        }
        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (width <= BoxMinValue)
                {
                    throw new ArgumentException($"{nameof(this.Width)} cannot be zero or negative.");
                }
                this.width = value;
            }
        }
        public double Height 
        {
            get
            {
                return this.height;
            }
            set 
            {
                if (value <= BoxMinValue)
                {
                    throw new ArgumentException($"{nameof(this.Height)} cannot be zero or negative.");
                }
                this.height = value;
            }
        }

        public Box(double length,double width,double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double SurfaceArea()
         => (2 * length * width) + (2 * length * height) + (2 * width * height);

        public double LateralSurfaceArea()
            => (2 * length * height) + (2 * width * height);

        public double Volume()
            => width * height * length;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb
                .AppendLine($"Surface Area - {this.SurfaceArea():f2}")
                .AppendLine($"Lateral Surface Area - {this.LateralSurfaceArea():f2}")
                .AppendLine($"Volume - {this.Volume():f2}");
            return sb.ToString().TrimEnd();
                
        }
    }
}
