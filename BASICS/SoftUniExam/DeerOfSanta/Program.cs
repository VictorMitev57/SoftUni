using System;

namespace DeerOfSanta
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int foodInKilos = int.Parse(Console.ReadLine());
            double foodForFirstDeer = double.Parse(Console.ReadLine());
            double foodForSecondDeer = double.Parse(Console.ReadLine());
            double foodForThirdDeer = double.Parse(Console.ReadLine());

            double totalFirstDeer = days * foodForFirstDeer;
            double totalSecondDeer = days * foodForSecondDeer;
            double totalThirdDeer = days * foodForThirdDeer;
            double total = totalFirstDeer + totalSecondDeer + totalThirdDeer;

            if (total <= foodInKilos)
            {
                Console.WriteLine($"{Math.Floor(foodInKilos - total)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(total - foodInKilos)} more kilos of food are needed.");
            }
        }
    }
}
