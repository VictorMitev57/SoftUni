using System;

namespace T12TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double commissions = double.Parse(Console.ReadLine());
            if (town == "Sofia")
            {
                if (commissions >= 0 && commissions <= 500)
                {
                    commissions *= 0.05;
                }
                else if (commissions > 500 && commissions <= 1000)
                {
                    commissions *= 0.07;
                }
                else if (commissions > 1000 && commissions <= 10000)
                {
                    commissions *= 0.08;
                }
                else if (commissions > 10000)
                {
                    commissions *= 0.12;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (town == "Varna")
            {
                if (commissions >= 0 && commissions <= 500)
                {
                    commissions *= 0.045;
                }
                else if (commissions > 500 && commissions <= 1000)
                {
                    commissions *= 0.075;
                }
                else if (commissions > 1000 && commissions <= 10000)
                {
                    commissions *= 0.10;
                }
                else if (commissions > 10000)
                {
                    commissions *= 0.13;
                }
                else
                {
                    Console.WriteLine("error");
                }

            }
            else if (town == "Plovdiv")
            {
                if (commissions >= 0 && commissions <= 500)
                {
                    commissions *= 0.055;
                }
                else if (commissions > 500 && commissions <= 1000)
                {
                    commissions *= 0.08;
                }
                else if (commissions > 1000 && commissions <= 10000)
                {
                    commissions *= 0.12;
                }
                else if (commissions > 10000)
                {
                    commissions *= 0.145;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
                return;
            }
            if (commissions > 0)
            {
                Console.WriteLine($"{commissions:F2}");
            }
        }
    }
}
