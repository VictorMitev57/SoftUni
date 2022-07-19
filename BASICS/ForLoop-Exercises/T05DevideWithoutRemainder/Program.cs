using System;

namespace T05DevideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double withoutRemainderBy2 = 0;
            double withoutRemainderBy3 = 0;
            double withoutRemainderBy4 = 0;
            double sum1 = 0;
            double sum2 = 0;
            double sum3 = 0;

            for (int i = 1; i <= n; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    sum1++;
                    withoutRemainderBy2 = (sum1 / n) * 100;
                }
                if (number % 3 == 0)
                {
                    sum2++;
                    withoutRemainderBy3 = (sum2 / n) * 100;
                }
                if (number % 4 == 0)
                {
                    sum3++;
                    withoutRemainderBy4 = (sum3 / n) * 100;
                }
            }
            Console.WriteLine($"{withoutRemainderBy2:F2}%");
            Console.WriteLine($"{withoutRemainderBy3:F2}%");
            Console.WriteLine($"{withoutRemainderBy4:F2}%");
        }
    }
}
