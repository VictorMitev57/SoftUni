using System;

namespace T05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                double num1 = i % 10;
                double num2 = i / 10;
                if (num1 + num2 == 5 || num1 + num2 == 7 || num1 + num2 == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
