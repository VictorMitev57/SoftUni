using System;

namespace T07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int interval = int.Parse(Console.ReadLine());
            const int capacity = 255;
            int sum = 0;
            int count = 0;
            while (count < interval)
            {
                int liters = int.Parse(Console.ReadLine());
                if (sum + liters > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    sum += liters;
                }

                count++;
            }

            Console.WriteLine(sum);
        }
    }
}
