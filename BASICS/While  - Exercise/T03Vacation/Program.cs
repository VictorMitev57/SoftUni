using System;

namespace T03Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeededForTheVacation = double.Parse(Console.ReadLine());
            double ownedMoney = double.Parse(Console.ReadLine());
            int daysCounter = 0;
            int spendCounter = 0;
            while (spendCounter != 5)
            {
                daysCounter++;
                string command = Console.ReadLine();
                double savedOrSpendMOney = double.Parse(Console.ReadLine());
                if (command == "spend")
                {
                    spendCounter++;
                    if (ownedMoney <= savedOrSpendMOney)
                    {
                        ownedMoney = 0;
                    }
                    else if (ownedMoney > savedOrSpendMOney)
                    {
                        ownedMoney -= savedOrSpendMOney;
                    }
                }
                else if (command == "save")
                {
                    spendCounter = 0;
                    ownedMoney += savedOrSpendMOney;
                    if (ownedMoney >= moneyNeededForTheVacation)
                    {
                        Console.WriteLine($"You saved the money for {daysCounter} days.");
                        break;
                    }
                }

            }
            if (spendCounter == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine($"{daysCounter}");
            }
        }
    }
}
