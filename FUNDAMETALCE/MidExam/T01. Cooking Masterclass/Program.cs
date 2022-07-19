using System;

namespace T01._Cooking_Masterclass
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double flourPrice = double.Parse(Console.ReadLine());
            double eggPrice = double.Parse(Console.ReadLine());
            double apronPrice = double.Parse(Console.ReadLine());

            double moreFlour = 0;
            double total = 0;

            for (int i = 1; i <= students; i++)
            {
                if (i % 5 ==0)
                {
                    moreFlour++;
                }
            }

            apronPrice = apronPrice * (Math.Ceiling(students * 1.2));
            total = flourPrice * (students - moreFlour) + (eggPrice * students * 10) + apronPrice;

            if (budget >= total)
            {
                Console.WriteLine($"Items purchased for {total:f2}$.");
            }
            else
            {
                Console.WriteLine($"{(total - budget):f2}$ more needed.");
            }

        }
    }
}
