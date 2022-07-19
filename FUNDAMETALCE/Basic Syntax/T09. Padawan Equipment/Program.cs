using System;

namespace T09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double moneyNeeded = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double lightsabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            double totalLightsabers = Math.Ceiling(studentsCount * 1.10) * lightsabersPrice;
            double totalRobes = studentsCount * robesPrice;
            double totalBelts = (studentsCount - studentsCount / 6) * beltsPrice;

            double totalSum = totalLightsabers + totalBelts + totalRobes;
            if (totalSum <= moneyNeeded)
            {
                Console.WriteLine($"The money is enough - it would cost {totalSum:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {(totalSum - moneyNeeded):f2}lv more.");
            }
        }
    }
}
