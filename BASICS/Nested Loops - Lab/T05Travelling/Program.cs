using System;

namespace T05Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            while (destination != "End")
            {
                double budget = double.Parse(Console.ReadLine());

                double moneyForVacation = 0;
                while (moneyForVacation < budget)
                {
                    moneyForVacation += double.Parse(Console.ReadLine());

                }
                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
        }
    }
}
