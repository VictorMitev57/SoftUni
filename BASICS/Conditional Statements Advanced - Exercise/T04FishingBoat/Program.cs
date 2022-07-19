using System;

namespace T04FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            double hire = 0;
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishmans = int.Parse(Console.ReadLine());
            switch (season)
            {
                case "Spring":
                    hire = 3000;
                    if (fishmans <= 6)
                    {
                        hire *= 0.90;
                    }
                    else if (fishmans >= 7 && fishmans <= 11)
                    {
                        hire *= 0.85;
                    }
                    else if (fishmans >= 12)
                    {
                        hire *= 0.75;
                    }
                    if (fishmans % 2 ==0)
                    {
                        hire *= 0.95;
                    }
                    break;
                case "Summer":
                    hire = 4200;
                    if (fishmans <= 6)
                    {
                        hire *= 0.90;
                    }
                    else if (fishmans >= 7 && fishmans <= 11)
                    {
                        hire *= 0.85;
                    }
                    else if (fishmans >= 12)
                    {
                        hire *= 0.75;
                    }
                    if (fishmans % 2 == 0)
                    {
                        hire *= 0.95;
                    }
                    break;
                case "Autumn":
                    hire = 4200;
                    if (fishmans <= 6)
                    {
                        hire *= 0.90;
                    }
                    else if (fishmans >= 7 && fishmans <= 11)
                    {
                        hire *= 0.85;
                    }
                    else if (fishmans >= 12)
                    {
                        hire *= 0.75;
                    }
                    break;
                case "Winter":
                    hire = 2600;
                    if (fishmans <= 6)
                    {
                        hire *= 0.90;
                    }
                    else if (fishmans >= 7 && fishmans <= 11)
                    {
                        hire *= 0.85;
                    }
                    else if (fishmans >= 12)
                    {
                        hire *= 0.75;
                    }
                    if (fishmans % 2 == 0)
                    {
                        hire *= 0.95;
                    }
                    break;
            }
            if (budget >= hire)
            {
                Console.WriteLine($"Yes! You have {(budget - hire):F2} leva left.");
            }
            if (budget < hire)
            {
                Console.WriteLine($"Not enough money! You need {(hire - budget):f2} leva.");
            }
        }
    }
}
