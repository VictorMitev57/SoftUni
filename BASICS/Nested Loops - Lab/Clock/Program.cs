using System;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int hour = 0; hour <= 23; hour++)
            {
                for (int mins = 0; mins <= 59; mins++)
                {
                    Console.WriteLine($"{hour}:{mins}");
                }
            }
        }
    }
}
