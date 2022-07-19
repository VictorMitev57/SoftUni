using System;
using System.Collections.Generic;
using System.Linq;

namespace T03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {

            var ledendaryItems = new Dictionary<string, int>();
            var junkMaterials = new Dictionary<string, int>();
            bool isLengendary = false;
            while (!isLengendary)
            {
                string[] input = Console.ReadLine().Split();
                for (int i = 1; i < input.Length; i += 2)
                {
                    string keyMaterial = input[i].ToLower();
                    int valueMaterial = int.Parse(input[i - 1]);
                    if (keyMaterial == "shards" || keyMaterial == "fragments " || keyMaterial == "motes ")
                    {
                        ledendaryItems[keyMaterial] = valueMaterial;
                        if (ledendaryItems[keyMaterial] >= 250)
                        {
                            isLengendary = true;
                            break;

                        }
                    }
                    else if(junkMaterials.ContainsKey(keyMaterial))
                    {
                        junkMaterials[keyMaterial] += valueMaterial;
                    }
                    else
                    {
                        junkMaterials.Add(keyMaterial, valueMaterial);
                    }
                }
            }

            if (ledendaryItems["shards"] >= 250 && ledendaryItems.ContainsKey("shards"))
            {
                Console.WriteLine("Shadowmourne obtained!");
                ledendaryItems["shards"] -= 250;
            }
            else if (ledendaryItems["fragments"] >= 250 && ledendaryItems.ContainsKey("fragments"))
            {
                Console.WriteLine("Valanyr obtained!");
                ledendaryItems["fragments"] -= 250;
            }
            else if (ledendaryItems["motes"] >= 250 && ledendaryItems.ContainsKey("motes"))
            {
                Console.WriteLine("Dragonwrath obtained!");
                ledendaryItems["motes"] -= 250;
            }

            foreach (var item in ledendaryItems.OrderByDescending(key => key.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in junkMaterials.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
