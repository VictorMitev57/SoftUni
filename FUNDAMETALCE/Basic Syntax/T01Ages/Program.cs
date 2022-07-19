using System;

namespace T01Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());

            switch (age)
            {
                case int num when num >= 0 && num <= 2: 
                    Console.WriteLine("baby");
                    break;
                case int num when num >= 3 && num <= 13:
                    Console.WriteLine("child");
                    break;
                case int num when num >= 14 && num <= 19:
                    Console.WriteLine("teenager");
                    break;
                case int num when num >= 20 && num <= 65:
                    Console.WriteLine("adult");
                    break;
                default:
                    Console.WriteLine("elder");
                    break;
            }
        }
    }
}
