using System;

namespace T04Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double sum = 0;
            while (command != "Going home")
            {
                double steps = double.Parse(command);
                sum += steps;
                if (sum >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{sum- 10000} steps over the goal!");
                    break;
                }
                command = Console.ReadLine();
            }
            if (command == "Going home")
            {
                command = Console.ReadLine();
                double steps = double.Parse(command);
                sum += steps;
                if (sum >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{sum - 10000} steps over the goal!");
                    return;
                }
                else if (sum < 10000)
                {
                    Console.WriteLine($"{10000 - sum} more steps to reach goal.");
                    return;
                }
            }
        }
    }
}
