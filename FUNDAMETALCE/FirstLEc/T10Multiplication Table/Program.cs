﻿using System;

namespace T10Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} X {i} = {i * n}");
            }
        }
    }
}