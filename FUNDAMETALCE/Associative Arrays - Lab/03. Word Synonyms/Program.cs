using System;
using System.Collections.Generic;

namespace _03._Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> wordSynonym = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();


                if (!wordSynonym.ContainsKey(word))
                {
                    wordSynonym[word] = new List<string>();
                }

                wordSynonym[word].Add(synonym);
            }

            foreach (var word in wordSynonym)
            {
                Console.WriteLine($"{word.Key} - {String.Join(", ", word.Value)}");
            }
        }
    }
}
