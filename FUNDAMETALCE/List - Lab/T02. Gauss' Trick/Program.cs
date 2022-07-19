using System;
using System.Collections.Generic;
using System.Linq;

namespace T02._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < number.Count/2; i++)
            {
                int sum = number[i] + number[number.Count - i - 1];
                Console.Write($"{sum} ");
            }

            if (number.Count % 2 == 1)
            {
                Console.WriteLine($"{number[number.Count/2]}");
            }
        }
    }
}
