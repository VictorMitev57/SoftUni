using System;

namespace T01Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            double premiere = 12;
            double normal = 7.50;
            double discount = 5;
            double price = 0;
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());

            if (type == "Premiere")
            {
                price = rows * colums * premiere;
            }
            if (type == "Normal")
            {
                price = rows * colums * normal;
            }
            if (type == "Discount")
            {
                price = rows * colums * discount;
            }
            Console.WriteLine($"{price:F2}");
        }
    }
}
