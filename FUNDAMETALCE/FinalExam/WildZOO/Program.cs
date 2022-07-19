using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace WildZOO
{

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> animals = new Dictionary<string, List<string>>();
            string commands = Console.ReadLine();

            while (commands != "EndDay")
            {
                List<string> needs = new List<string>();


                string[] currCommand = commands.Split(":");
                if (currCommand[0] == "Add")
                {
                    //Add: Adam-4500-ByTheCreek
                    string[] animal = currCommand[1].Split("-"); // Adam   4500   ByTheCreek
                    if (!animals.ContainsKey(animal[0]))
                    {
                        needs.Add(int.Parse(animal[1]).ToString());
                        needs.Add(animal[2]);
                        animals.Add(animal[0], needs);
                    }
                    else
                    {
                        animals[needs[0]][0] += int.Parse(animal[1]);
                    }
                }
                else if (currCommand[0] == "Feed")
                {
                    
                }

                commands = Console.ReadLine();
            }
        }
    }


}
