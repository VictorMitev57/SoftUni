using System;
using System.Collections.Generic;
using System.Linq;

namespace T04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> order = new Dictionary<string, int>();
            string products = "";
            double price = 0;
            int quantity = 0;
            decimal totalPrice = 0;


            string input = Console.ReadLine();
            while (input != "buy")
            {
                string[] token = input.Split(" ");
                products = token[0];
                price = double.Parse(token[1]);
                quantity = int.Parse(token[2]);

                if (!order.ContainsKey(products))
                {
                    order[products] = 0;
                    order[products] += quantity;
                    totalPrice = (decimal)(quantity * price);

                }

                else
                {
                    totalPrice = 0;
                    order[products] += quantity;
                    totalPrice = (decimal)(order[products] * price);
                    order[products] = (int)totalPrice;
                }

                input = Console.ReadLine();
            }


            foreach (var product in order)
            {
                Console.WriteLine($"{product.Key} -> {product.Value:f2}");
            }
        }
    }
}
