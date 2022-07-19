using System;

namespace T05AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double account = 0;
            while (command != "NoMoreMoney")
            {
               double  currentSum = double.Parse(command);
                if (currentSum < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                account += currentSum;
                Console.WriteLine($"Increase: {currentSum:f2}");
                command = Console.ReadLine();
            }
            Console.WriteLine($"Total: {account:f2}");
        }
    }
}
