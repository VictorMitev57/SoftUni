using System;

namespace T06NumberinRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number >= -100 && number <= 100)
            {
                if (number == 0)
                {
                    Console.WriteLine("No");
                }
                if (number != 0)
                {
                    Console.WriteLine("Yes");
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
