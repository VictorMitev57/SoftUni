using System;

namespace Т07WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSec = double.Parse(Console.ReadLine());
            double distanceM = double.Parse(Console.ReadLine());
            double timeInSecFor1m = double.Parse(Console.ReadLine());
            double alltime = distanceM * timeInSecFor1m;
            double sec = Math.Floor(distanceM / 15) * 12.5;
            double total = sec + alltime;
            if (recordInSec <= total)
            {
                double fail =  total - recordInSec;
                Console.WriteLine($"No, he failed! He was {fail:f2} seconds slower.");
            }
            else if (recordInSec > total)
            {
                double record = total;
                Console.WriteLine($"Yes, he succeeded! The new world record is {record:f2} seconds.");
            }
        }
    }
}
