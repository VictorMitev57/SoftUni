using System;

namespace T06Sum_And_Product
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int product = 0;
            for (int a = 1; a <= 9; a++)
            {
                for (int b = 9; b >= a; b--) ///////////
                {
                    for (int c = 0; c <= 9; c++)
                    {
                        for (int d = 9; d >= c; d--) ///////////
                        {
                            sum = a + b + c + d;
                            product = a * b * c * d;
                            if (sum == product && n % 10 == 5)
                            {
                                Console.WriteLine($"{a}{b}{c}{d}");
                                Environment.Exit(0);
                            }
                            else if (product / sum == 3 && n % 3 == 0)
                            {
                                Console.WriteLine($"{d}{c}{b}{a}");
                                Environment.Exit(0);
                            }
                            sum = 0;
                            product = 0;
                        }
                    }
                }
            }
            Console.WriteLine("Nothing found");
        }
    }
}
