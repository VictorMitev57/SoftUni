using System;
using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace T._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Regex regex = new Regex(@"(\|)([A-Z]{4,})\1:(#)([A-Z][a-z]+) [A-Za-z][a-z]+\3");


            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                bool valide = regex.IsMatch(input);
                if (valide == true)
                {
                    string[] bossName = input.Split("|");
                    string[] secondName = bossName[2].Split("#");
                    Console.Write(bossName[1] + ", ");
                    Console.WriteLine("The " + secondName[1]);

                    int strength = bossName[1].Length;
                    int armor = secondName[1].Length;

                    Console.WriteLine($">> Strength: {strength}");
                    Console.WriteLine($">> Armor: {armor}");
                }
                else
                {
                    Console.WriteLine("Access denied!");
                }
            }
        }
    }
}
