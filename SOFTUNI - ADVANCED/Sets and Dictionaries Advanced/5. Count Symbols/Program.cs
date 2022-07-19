using System;
using System.Collections.Generic;

namespace _5._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            SortedDictionary<char, int> symbols = new SortedDictionary<char, int>();

            foreach (char letter in input)
            {
                if (!symbols.ContainsKey(letter))
                {
                    symbols.Add(letter, 1);
                }
                else
                {
                    symbols[letter]++;
                }
            }
            foreach (var letter in symbols)
            {
                Console.WriteLine($"{letter.Key}: {letter.Value} time/s");
            }
        }
    }
}
