using System;

namespace T05Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            string place = "";
            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    budget *= 0.30;
                    place = "Camp";
                }
                else if (season =="winter")
                {
                    budget *= 0.70;
                    place = "Hotel";
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    budget *= 0.40;
                    place = "Camp";
                }
                else if (season == "winter")
                {
                    budget *= 0.80;
                    place = "Hotel";
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                if (season == "summer" || season == "winter")
                {
                    budget *= 0.90;
                    place = "Hotel";
                }
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{place} - {budget:F2}");
        }
    }
}
