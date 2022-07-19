using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            //string phones = Console.ReadLine();
            //Regex regex = new Regex(@"[ ]?\+([0-9]{3})([ -])[2]\2([0-9]{3})\2([0-9]{4})\b");

            //MatchCollection matches = regex.Matches(phones);

            //var phoneMatch = matches.Cast<Match>().Select(x => x.Value.Trim()).ToArray();

            //Console.WriteLine(string.Join(", ", phoneMatch));

            var regex = @"[ ]*\+([0-9]{3})([- ])(2)\2[0-9]{3}(\2)[0-9]{4}\b";

            var phones = Console.ReadLine();

            var phoneMatches = Regex.Matches(phones, regex);

            var matches = phoneMatches.Cast<Match>().Select(a => a.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ", matches));
        }
    }
}
