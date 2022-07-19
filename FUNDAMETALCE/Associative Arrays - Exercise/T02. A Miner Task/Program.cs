using System;
using System.Collections.Generic;

namespace T02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string resources = Console.ReadLine();
            Dictionary<string, int> resoursesAndQuant = new Dictionary<string, int>();
            while (resources != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (!resoursesAndQuant.ContainsKey(resources))
                {
                    resoursesAndQuant[resources] = 0;
                }

                resoursesAndQuant[resources] += quantity;
                resources = Console.ReadLine();
            }

            foreach (var kvp in resoursesAndQuant)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
