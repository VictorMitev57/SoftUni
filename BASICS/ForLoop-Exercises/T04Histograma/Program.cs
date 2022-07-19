using System;

namespace T04Histograma
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;
            double sum1 = 0;
            double sum2 = 0;
            double sum3 = 0;
            double sum4 = 0;
            double sum5 = 0;
            for (int i = 1; i <= n; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (number < 200)
                {
                    sum1 ++;
                    p1 = (sum1 / n) * 100;
                }
                if (number >=200 && number <= 399 )
                {
                    sum2 ++;
                    p2 = (sum2 / n) * 100;
                }
                if (number >= 400 && number <= 599 )
                {
                    sum3 ++;
                    p3 = (sum3 / n) * 100;
                }
                if (number >= 600 && number <= 799)
                {
                    sum4 ++;
                    p4 = (sum4 / n) * 100;
                }
                if(number >= 800)
                {
                    sum5 ++;
                    p5 = (sum5 / n) * 100;
                }
            }
            Console.WriteLine($"{p1:F2}%");
            Console.WriteLine($"{p2:F2}%");
            Console.WriteLine($"{p3:F2}%");
            Console.WriteLine($"{p4:F2}%");
            Console.WriteLine($"{p5:F2}%");
        }
    }
}
