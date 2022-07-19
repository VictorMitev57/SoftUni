using System;
using System.Collections.Generic;

namespace T01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] word = Console.ReadLine().ToCharArray();
            Dictionary<char, int> letters = new Dictionary<char, int>();

            foreach (var letter in word)
            {
                if (letter != ' ')
                {
                    if (!letters.ContainsKey(letter))
                    {
                        letters[letter] = 0;
                    }

                    letters[letter]++;
                }
            }

            foreach (var kvp in letters)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }

        }
    }
}
