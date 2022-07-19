using System;

namespace T06Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int sum = lenght * width;
            string command = Console.ReadLine();
            int sumOfPieces = 0;
            while (command != "STOP")
            {
                if (sumOfPieces < sum)
                {
                    int piece = int.Parse(command);
                    sumOfPieces += piece;
                }
                if (sumOfPieces >= sum)
                {
                    Console.WriteLine($"No more cake left! You need {sumOfPieces - sum} pieces more.");
                    break;
                }
                command = Console.ReadLine();
            }
            if (command == "STOP")
            {
                if (sumOfPieces >= sum)
                {
                    Console.WriteLine($"No more cake left! You need {sumOfPieces - sum} pieces more.");
                }
                else if (sumOfPieces < sum)
                {
                    Console.WriteLine($"{sum - sumOfPieces} pieces are left.");
                }
            }
        }
    }
}
