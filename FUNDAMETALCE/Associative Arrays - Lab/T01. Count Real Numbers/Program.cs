using System;
using System.Collections.Generic;
using System.Linq;

namespace T01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            SortedDictionary<double, int> count = new SortedDictionary<double, int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (!count.ContainsKey(numbers[i]))
                {
                    count.Add(numbers[i], 0);
                }

                count[numbers[i]]++;
            }

            foreach (var item in count)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
