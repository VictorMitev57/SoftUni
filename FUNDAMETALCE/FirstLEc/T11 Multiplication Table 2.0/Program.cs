using System;

namespace T11_Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            if (num2 > 10)
            {
                Console.WriteLine($"{num1} X {num2} = {num1 * num2}");
                Environment.Exit(0);
            }
            else if (num2 <= 10)
            {
                for (int i = num2; i <= 10 ; i++)
                {
                    Console.WriteLine($"{num1} X {i} = {num1 * i}");
                }
            }
        }
    }
}
