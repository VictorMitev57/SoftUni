﻿using System;

namespace T03Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int validCombinations = 0;
            for (int num1 = 0; num1 <= n; num1++)
            {
                for (int num2 = 0; num2 <= n; num2++)
                {
                    for (int num3 = 0; num3 <= n; num3++)
                    {
                        if (num1 + num2 + num3 == n)
                        {
                            validCombinations++;
                        }
                    }
                }
            }
            Console.WriteLine(validCombinations);
        }
    }
}