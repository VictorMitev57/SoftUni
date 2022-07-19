using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string furniture = Console.ReadLine();
            string regex = @">>(?<name>[A-Za-z]+)<<(?<price>(\d+(.\d+)?))!(?<quantity>\d+)";
            var list = new List<string>();
            double totalPrice = 0;


            while (furniture != "Purchase")
            {
                Match matchesFurniture = Regex.Match(furniture, regex, RegexOptions.IgnoreCase);
                if (matchesFurniture.Success)
                {
                    var name = matchesFurniture.Groups["name"].Value;
                    var price = double.Parse(matchesFurniture.Groups["price"].Value);
                    var quantity = int.Parse(matchesFurniture.Groups["quantity"].Value);
                    list.Add(name);
                    totalPrice += price * quantity;
                }

                furniture = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");
            list.ForEach(Console.WriteLine);
            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
