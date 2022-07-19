using System;

namespace T03NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            double roses = 5;
            double dahlias = 3.80;
            double tulips = 2.80;
            double narcissus = 3;
            double gladiolus = 2.50;
            string type = Console.ReadLine();             /*"Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"*/
            int flowersQuantity = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double price = 0;
            if (type == "Roses")
            {
                price = flowersQuantity * roses;
                if (flowersQuantity > 80)
                {
                    price *= 0.90;
                }
            }
            else if (type == "Dahlias")
            {
                price = flowersQuantity * dahlias;
                if (flowersQuantity > 90)
                {
                    price *= 0.85;
                }
            }
            else if (type == "Tulips")
            {
                price = flowersQuantity * tulips;
                if (flowersQuantity > 80 )
                {
                    price *= 0.85;
                }
            }
            else if (type == "Narcissus")
            {
                price = flowersQuantity * narcissus;
                if (flowersQuantity < 120)
                {
                    price *= 1.15;
                }
            }
            else if (type == "Gladiolus")
            {
                price = flowersQuantity * gladiolus;
                if (flowersQuantity < 80)
                {
                    price *= 1.20;
                }
            }
            if (budget >= price)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowersQuantity} {type} and {(budget - price):F2} leva left.");
            }
            else if (price > budget)
            {
                Console.WriteLine($"Not enough money, you need {(price - budget):F2} leva more.");
            }
        }
    }
}
