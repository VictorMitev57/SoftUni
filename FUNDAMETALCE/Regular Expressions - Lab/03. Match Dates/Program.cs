using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<day>[0-9]{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>[0-9]{4})\b";

            string datesString = Console.ReadLine();

            MatchCollection dates = Regex.Matches(datesString, pattern);

            foreach (Match matches in dates)
            {
                var day = matches.Groups["day"].Value;
                var month = matches.Groups["month"].Value;
                var year = matches.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }

            //MatchCollection matches = Regex.Matches(Console.ReadLine(),
            //    @"\b(?<day>[0-9]{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>[0-9]{4})\b");

            //foreach (Match dates in matches)
            //{
            //    Console.WriteLine($"Day: {dates.Groups["day"]}, Month: {dates.Groups["month"]}, Year: {dates.Groups["year"]}");
            //}
        }
    }
}
