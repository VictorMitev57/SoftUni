using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string products = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            Products(products, quantity);
        }

        static void Products(string products, double quantity)
        {
            switch (products)
            {
                case "water":
                    Console.WriteLine($"{(quantity * 1.00):f2}");
                    break;
                case "coke":
                    Console.WriteLine($"{(quantity * 1.40):f2}");
                    break;
                case "coffee":
                    Console.WriteLine($"{(quantity * 1.50):f2}");
                    break;
                case "snacks":
                    Console.WriteLine($"{(quantity * 2.00):f2}");
                    break;
            }
        }
    }
}
