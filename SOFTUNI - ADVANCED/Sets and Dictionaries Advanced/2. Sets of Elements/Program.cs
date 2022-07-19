using System;
using System.Collections.Generic;

namespace _2._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] set = Console.ReadLine().Split(" ");

            int n = int.Parse(set[0]);
            int m = int.Parse(set[1]);

            HashSet<int> firstSet = new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                firstSet.Add(int.Parse(Console.ReadLine()));
            }
            HashSet<int> secondSet = new HashSet<int>();
            for (int i = 0; i < m; i++)
            {
                secondSet.Add(int.Parse(Console.ReadLine()));
            }

            firstSet.IntersectWith(secondSet);
            Console.WriteLine(String.Join(" ", firstSet));
        }
    }
}
