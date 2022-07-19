using System;

namespace T04BackIn30Min
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            min += 30;
            if (min > 59)
            {
                min -= 60;
                hour++;
                if (hour > 23)
                {
                    hour = 0;
                }
            }
            Console.WriteLine($"{hour}:{min:d2}");
        }
    }
}
