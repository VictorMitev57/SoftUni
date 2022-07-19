using System;

namespace T01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] days =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            if (n > 7 || n <= 0)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(days[n - 1]);
            }
        }
    }
}
