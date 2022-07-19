using System;
using System.Collections.Generic;

namespace _06._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Queue<string> customers = new Queue<string>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Paid")
                {
                    foreach (var customer in customers)
                    {
                        Console.WriteLine(customer);
                    }
                    customers.Clear();

                }
                if (command == "End")
                {
                    Console.WriteLine($"{customers.Count} people remaining.");
                    break;
                }
                if (command != "Paid" && command != "End")
                {
                    customers.Enqueue(command);
                }

            }
        }
    }
}
