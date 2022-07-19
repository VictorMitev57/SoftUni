using System;

namespace T07Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            double coins = 0;
            double totalSum = 0;
            double priceOfProducts = 0;
            double totalProdPrice = 0;

            while (command != "Start")
            {
                command = Console.ReadLine();
                if (command == "Start")
                {
                    break;
                }
                coins = double.Parse(command);
                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                {
                    totalSum += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
            }


            string command2 = Console.ReadLine(); ;
            while (command != "End")
            {
                if (command2 == "End")
                {
                    break;
                }
                
                if (command2 == "Nuts")
                {
                    priceOfProducts = 2.0;
                    if (totalSum >= priceOfProducts)
                    {
                        Console.WriteLine($"Purchased nuts");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (command2 == "Water")
                {
                    priceOfProducts = 0.7;
                    if (totalSum >= priceOfProducts)
                    {
                        Console.WriteLine($"Purchased water");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (command2 == "Crisps")
                {
                    priceOfProducts = 1.5;
                    if (totalSum >= priceOfProducts)
                    {
                        Console.WriteLine($"Purchased crisps");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (command2 == "Soda")
                {
                    priceOfProducts = 0.8;
                    if (totalSum >= priceOfProducts)
                    {
                        Console.WriteLine($"Purchased soda");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (command2 == "Coke")
                {
                    priceOfProducts = 1.0;
                    if (totalSum >= priceOfProducts)
                    {
                        Console.WriteLine($"Purchased coke");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                totalProdPrice += priceOfProducts;
                if (totalSum >= priceOfProducts)
                {
                    totalSum -= priceOfProducts;
                }
                else
                {
                    totalSum = totalSum;
                }
                command2 = Console.ReadLine();
            }
            Console.WriteLine($"Change: {totalSum:f2}");
        }
    }
}
