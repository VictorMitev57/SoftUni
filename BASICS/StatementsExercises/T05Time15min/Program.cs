using System;

namespace T05Time15min
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int totalmin = minutes + 15;
             if (totalmin >= 60)
            {
                hours += 1;
                minutes = totalmin - 60;
            }
            else if (totalmin < 60)
            {
                hours += 0;
                minutes = totalmin;;
            }
            if (hours > 23)
            {
                hours = 0;
                minutes = totalmin - 60;
            }
            Console.WriteLine($"{hours}:{minutes:d2}");
        }
    }
}
