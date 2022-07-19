using System;

namespace T06Godzillavs.Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statickman = int.Parse(Console.ReadLine());
            double clothesperperson = double.Parse(Console.ReadLine());

            double decor = budget * 0.10;
            double priceofallclothes = statickman * clothesperperson;
            double total;
            if (statickman > 150)
            {
                double discount = priceofallclothes -(priceofallclothes * 0.10);
                total = discount + decor;

            }
            else
            {
                total = decor + priceofallclothes;
            }
            if (total > budget)
            {
                double neededmoney = total - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {neededmoney:f2} leva more.");
            }
            else if (budget >= total)
            {
                double neededmoney = budget - total;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {neededmoney:f2} leva left.");
            }
        }
    }
}
