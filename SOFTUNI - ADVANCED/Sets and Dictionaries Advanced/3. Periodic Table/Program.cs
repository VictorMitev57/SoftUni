using System;
using System.Collections.Generic;

namespace _3._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> chElements = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] nameOfElements = input.Split(" ");
                foreach (var el in nameOfElements)
                {
                    chElements.Add(el);
                }
            }

            Console.WriteLine(String.Join(" ", chElements));
        }
    }
}
