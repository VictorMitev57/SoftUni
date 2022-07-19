using System;
using System.Collections.Generic;

namespace _6._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int colorNUmber = int.Parse(Console.ReadLine());

            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < colorNUmber; i++)
            {
                string input = Console.ReadLine();
                string color = input.Split(" -> ")[0];
                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }
                Dictionary<string, int> clothes = wardrobe[color];
                string[] inputClothes = input.Split(" -> ")[1]
                                                .Split(",");
                foreach (var cloth in inputClothes)
                {
                    if (!clothes.ContainsKey(cloth))
                    {
                        clothes.Add(cloth, 1);
                    }
                    else
                    {
                        clothes[cloth]++;
                    }
                }
            }
            string[] search = Console.ReadLine().Split(" ");
            string searchedColor = search[0];
            string searchedCloth = search[1];

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");
                Dictionary<string, int> curCloth = color.Value;

                foreach (var cloth in curCloth)
                {
                    if (searchedCloth == cloth.Key && searchedColor == color.Key)
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }
                }
            }
        }
    }
}
