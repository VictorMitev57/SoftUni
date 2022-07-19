using System;

namespace T04ComputerFirm
{
    class Program
    {
        static void Main(string[] args)
        {
            int computers = int.Parse(Console.ReadLine());

            int rating = 0;
            double sales = 0;
            double totalSales = 0;
            double totalRating = 0;

            for (int i = 1; i <= computers; i++)
            {
                int number = int.Parse(Console.ReadLine());
                rating = number % 10;
                sales = number / 10;
                if (rating == 2)
                {
                    sales *= 0;
                }
                else if (rating == 3)
                {
                    sales *= 0.50;
                }
                else if (rating == 4)
                {
                    sales *= 0.70;
                }
                else if (rating == 5)
                {
                    sales *= 0.85;
                }
                else if (rating == 6)
                {
                    sales = sales;
                }
                totalSales += sales;
                totalRating += rating;
            }
            totalRating /= computers;
            Console.WriteLine($"{totalSales:f2}");
            Console.WriteLine($"{totalRating:f2}");
        }
    }
}
