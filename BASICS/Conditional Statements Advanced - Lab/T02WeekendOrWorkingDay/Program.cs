using System;

namespace T02WeekendOrWorkingDay
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            switch (text)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    Console.WriteLine("Working day");
                    break;
                case "Saturday":
                case "Sunday":
                    Console.WriteLine("Weekend");
                    break;
                default: Console.WriteLine("Error");
                    break;
            }
        }
    }
}
