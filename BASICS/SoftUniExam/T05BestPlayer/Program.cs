using System;

namespace T05BestPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            string name = "";
            string name1 = "";
            int maxGoals = 0;

            bool hatTrick = false;
            while (command != "END")
            {
                int goals = int.Parse(Console.ReadLine());
                if (goals >= 3)
                {
                    hatTrick = true;
                }
                name = command;
                if (goals > maxGoals)
                {
                    name1 = name;
                    maxGoals = goals;
                }
                if (goals >= 10)
                {
                    break;
                }
                command = Console.ReadLine();
            }
            if (maxGoals < 10)
            {
                Console.WriteLine($"{name1} is the best player!");
            }
            else if (maxGoals >= 10)
            {
                Console.WriteLine($"{name} is the best player!");
            }
            if (hatTrick == true)
            {
                Console.WriteLine($"He has scored {maxGoals} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {maxGoals} goals.");
            }
        }
    }
}
