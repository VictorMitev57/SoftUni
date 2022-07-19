using System;

namespace T03Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;
            double totalPrice = 0;
            double freeEnter = 0;

            if (day == "Friday")
            {

                if (type == "Students")
                {
                    price = 8.45;
                    totalPrice = price * peopleCount;
                    if (peopleCount >= 30)
                    {
                        totalPrice *= 0.85;
                    }
                }
                else if (type == "Business")
                {
                    price = 10.90;
                    totalPrice = price * peopleCount;
                    if (peopleCount >= 100)
                    {
                        freeEnter = 10 * price;
                        totalPrice -= freeEnter;
                    }
                }
                else if (type == "Regular")
                {
                    price = 15;
                    totalPrice = price * peopleCount;
                    if (peopleCount >= 10 && peopleCount <= 20)
                    {
                        totalPrice *= 0.95;
                    }
                }
            }
            else if (day == "Saturday")
            {

                if (type == "Students")
                {
                    price = 9.80;
                    totalPrice = price * peopleCount;
                    if (peopleCount >= 30)
                    {
                        totalPrice *= 0.85;
                    }
                }
                else if (type == "Business")
                {
                    price = 15.60;
                    totalPrice = price * peopleCount;
                    if (peopleCount >= 100)
                    {
                        freeEnter = 10 * price;
                        totalPrice -= freeEnter;
                    }
                }
                else if (type == "Regular")
                {
                    price = 20;
                    totalPrice = price * peopleCount;
                    if (peopleCount >= 10 && peopleCount <= 20)
                    {
                        totalPrice *= 0.95;
                    }
                }
            }
            else if (day == "Sunday")
            {

                if (type == "Students")
                {
                    price = 10.46;
                    totalPrice = price * peopleCount;
                    if (peopleCount >= 30)
                    {
                        totalPrice *= 0.85;
                    }
                }
                else if (type == "Business")
                {
                    price = 16;
                    totalPrice = price * peopleCount;
                    if (peopleCount >= 100)
                    {
                        freeEnter = 10 * price;
                        totalPrice -= freeEnter;
                    }
                }
                else if (type == "Regular")
                {
                    price = 22.50;
                    totalPrice = price * peopleCount;
                    if (peopleCount >= 10 && peopleCount <= 20)
                    {
                        totalPrice *= 0.95;
                    }
                }
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
