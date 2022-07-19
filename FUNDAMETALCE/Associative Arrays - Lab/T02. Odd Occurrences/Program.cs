using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace T02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string wordsToLowerCase = word.ToLower();

                if (counts.ContainsKey(wordsToLowerCase))
                {
                    counts[wordsToLowerCase]++;
                }
                else
                {
                    counts.Add(wordsToLowerCase, 1);
                }
            }

            foreach (var item in counts)
            {
                if (item.Value % 2 == 0)
                {
                    Console.WriteLine(item.Key + " ");
                }
            }
        }
    }
}
