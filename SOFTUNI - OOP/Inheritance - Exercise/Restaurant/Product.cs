using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Product
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private decimal price;

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
