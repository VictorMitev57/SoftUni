using System;
using System.Collections.Generic;
using System.Linq;

namespace T05._Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            bool a = true;
            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
                return;
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers.RemoveAt(i);
                    i--;
                }

            }

            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                Console.Write($"{numbers[i]} ");
                a = false;
            }

            if (a == true)
            {
                Console.WriteLine("empty");
            }
        }
    }
}
