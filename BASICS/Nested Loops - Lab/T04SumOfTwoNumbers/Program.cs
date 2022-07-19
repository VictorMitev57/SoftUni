using System;

namespace T04SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int combinations = 0;
            for (int num1 = start; num1 <= end; num1++)
            {
                for (int num2 = start; num2 <= end; num2++)
                {
                    combinations++;
                    if (num1 + num2 == magicNum)
                    {
                        Console.WriteLine($"Combination N:{combinations} ({num1} + {num2} = {magicNum})");
                        Environment.Exit(0);
                    }
                }
            }
            Console.WriteLine($"{combinations} combinations - neither equals {magicNum}");
        }
    }
}
