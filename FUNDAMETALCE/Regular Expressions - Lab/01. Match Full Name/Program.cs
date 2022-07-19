using System;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string names = Console.ReadLine();

            Regex regex = new Regex(@"\b[A-Z][a-z]{1,} [A-Z][a-z]{1,}");

            MatchCollection matches = regex.Matches(names);

            foreach (Match match in matches)
            {
                Console.Write(match.Value + " ");
            }

        }
    }
}
