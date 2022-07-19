using System;

namespace T03PrimeORNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int primeNum = 0;
            int nonPrimeNum = 0;
            int count = 0;
            while (command != "stop")
            {
                int number = int.Parse(command);
                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else if (number > 0)
                {
                    for (int i = 1; i <= number; i++)
                    {
                        if (number % i ==0)
                        {
                            count++;
                        }

                    }
                    if (count == 2)
                    {
                        primeNum += number;
                    }
                    else
                    {
                        nonPrimeNum += number;
                    }
                }
                count = 0;
                command = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeNum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeNum}");
        }
    }
}
