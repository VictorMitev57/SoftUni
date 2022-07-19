using System;

namespace T11CleverLilly
{
    class Program
    {
        static void Main(string[] args)
        {
            int ages = int.Parse(Console.ReadLine());
            double priceOfTheWashingMachine = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());
            int  OddCounter = 0;
            double savedMoney = 0;
            double MoneyGifted = 10; 
            for (

                int i = 1; i <= ages; i++)
            {
                if (i % 2 == 0)
                {
                    savedMoney += MoneyGifted;
                    MoneyGifted += 10;
                    savedMoney--;

                }
                else
                {
                    OddCounter++;
                }
            }
            double profitFromToys = OddCounter * toyPrice;
            savedMoney += profitFromToys;
            if (savedMoney >= priceOfTheWashingMachine)
            {
                Console.WriteLine($"Yes! {(savedMoney - priceOfTheWashingMachine):F2}");
            }
            else
            {
                Console.WriteLine($"No! {(priceOfTheWashingMachine - savedMoney):F2}");
            }
        }
    }
}
