using System;

namespace T09Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int volume = width * lenght * height;
            int freeSpace = 0;
            int sum = 0;
            string command = Console.ReadLine();
            while (command != "Done")
            {
                freeSpace = int.Parse(command);
                sum += freeSpace;
                if (sum >= volume)
                {
                    Console.WriteLine($"No more free space! You need {sum - volume} Cubic meters more.");
                    break;
                }
                command = Console.ReadLine();
            }
            if (volume > sum)
            {
                Console.WriteLine($"{Math.Abs(volume - sum)} Cubic meters left.");
            }
        }
    }
}
