using System;
using System.Collections.Generic;
using System.Linq;

namespace Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityOfFood = int.Parse(Console.ReadLine());

            List<int> orderedFood = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            Queue<int> ordersQueue = new Queue<int>(orderedFood);

            Console.WriteLine(ordersQueue.Max());
            while (ordersQueue.Count > 0)
            {
                if (quantityOfFood >= ordersQueue.Peek())
                {

                    quantityOfFood -= ordersQueue.Peek();
                    ordersQueue.Dequeue();
                }
                else
                {
                    break;
                }
            }

            if (ordersQueue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: " + string.Join(" ", ordersQueue));
            }
        }
    }
}
