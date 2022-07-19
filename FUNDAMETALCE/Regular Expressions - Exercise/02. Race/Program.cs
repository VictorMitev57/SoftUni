using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> participant = new Dictionary<string, int>();

            var patternName = new Regex(@"(?<name>[A-Za-z]+)");
            var patternDigit = @"(?<distance>[0-9]+)";

            var name = Console.ReadLine().Split(",").ToList();

            int sumOfDigit = 0;

            string input = Console.ReadLine();
            while (input != "end of race")
            {
                var matchedName = patternName.Match(input);
                var matchedDigit = Regex.Match(input, patternDigit);

                var currName = string.Join("", matchedName);
                var currDigit = string.Join("",matchedDigit);
                for (int i = 0; i < currDigit.Length; i++)
                {
                    sumOfDigit += int.Parse(currDigit[i].ToString());
                }

                if (!participant.ContainsKey(currName))
                {
                    participant.Add(currName, sumOfDigit);
                }
                else
                {
                    participant[currName] += sumOfDigit;
                }

                input = Console.ReadLine();
            }

            var winners = participant.OrderByDescending(x => x.Value).Take(3);

            var firstPlace = winners.Take(1);
            var secondPlace = winners.OrderByDescending(X => X.Value).Take(2).OrderBy(x => x.Value).Take(1);
            var thirdPlace = winners.OrderBy(x => x.Value).Take(1);

            foreach (var firstName in firstPlace)
            {
                Console.WriteLine($"1st place: {firstName.Key}");
            }
            foreach (var second in secondPlace)
            {
                Console.WriteLine($"1st place: {second.Key}");
            }
            foreach (var third in thirdPlace)
            {
                Console.WriteLine($"1st place: {third.Key}");
            }
        }
    }
}
