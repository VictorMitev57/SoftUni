using System;

namespace T022._Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pounds = decimal.Parse(Console.ReadLine());
            pounds *= 1.31m;
            Console.WriteLine($"{pounds:f3}");
        }
    }
}
