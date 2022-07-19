using System;

namespace T08._Town_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            string grad = Console.ReadLine();
            long population = long.Parse(Console.ReadLine());
            short area = short.Parse(Console.ReadLine());
            Console.WriteLine($"Town {grad} has population of {population} and area {area} square km.");

        }
    }
}
