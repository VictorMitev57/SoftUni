using System;

namespace TO7ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            // •Пъзел - 2.60 лв.
            //•	Говореща кукла -3 лв.
            //•	Плюшено мече -4.10 лв.
            //•	Миньон - 8.20 лв.
            //•	Камионче - 2 лв.
            const double puzzle = 2.60;
            const double doll = 3;
            const double bear = 4.10;
            const double minion = 8.20;
            const double trucks = 2;
            // second stage 
            double holidayprice = double.Parse(Console.ReadLine());

            //
            int puzlleAM = int.Parse(Console.ReadLine());
            int dollsAM = int.Parse(Console.ReadLine());
            int bearsAM = int.Parse(Console.ReadLine());
            int minionsAM = int.Parse(Console.ReadLine());
            int trucksAM = int.Parse(Console.ReadLine());

            //tird stage all 
            double puzzlePrice = puzzle * puzlleAM;
            double dollsPrice = doll * dollsAM;
            double bearsPrices = bear * bearsAM;
            double minionPrice = minion * minionsAM;
            double trucksPrice = trucks * trucksAM;
            //

            double total = puzzlePrice + dollsPrice + bearsPrices + minionPrice + trucksPrice;
            double sumToys = puzlleAM + dollsAM + bearsAM + minionsAM + trucksAM;
            if (sumToys >= 50)
            {
                total *= 0.75;
                double rent = total * 0.90;
                if (rent >= holidayprice)
                {
                    Console.WriteLine($"Yes! {(rent - holidayprice):f2} lv left.");
                }
                else if (rent < holidayprice)
                {
                    Console.WriteLine($"Not enough money! {(holidayprice - rent):f2} lv needed.");
                }
            }
            else if (sumToys < 50)
            {
                double rent = total * 0.90;
                if (rent >= holidayprice)
                {
                    Console.WriteLine($"Yes! {(rent - holidayprice):f2} lv left.");
                }
                else if (rent < holidayprice)
                {
                    Console.WriteLine($"Not enough money! {(holidayprice - rent):f2} lv needed.");
                }
            }
        }
    }
}
