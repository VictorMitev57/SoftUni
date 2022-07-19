using System;

namespace T03OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double OddSum = 0;
            double OddMin = double.MaxValue;
            double OddMax = double.MinValue;
            double EvenSum = 0;
            double EvenMin = double.MaxValue;
            double EvenMax = double.MinValue;
            for (int i = 1; i <= n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    EvenSum += number;
                    if (number < EvenMin)
                    {
                        EvenMin = number;
                    }
                    if (EvenMax < number)
                    {
                        EvenMax = number;
                    }
                }
                else
                {
                    OddSum += number;
                    if (number < OddMin)
                    {
                        OddMin = number;
                    }
                    if (OddMax < number)
                    {
                        OddMax = number;
                    }
                }
            }
            Console.WriteLine($"OddSum={OddSum:F2},");
            if (OddSum == 0)
            {
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={OddMin:F2},");
                Console.WriteLine($"OddMax={OddMax:F2},");
            }
            Console.WriteLine($"EvenSum={EvenSum:F2},");
            if (EvenSum == 0)
            {
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMin={EvenMin:F2},");
                Console.WriteLine($"EvenMax={EvenMax:F2}");
            }


        }

    }
}
