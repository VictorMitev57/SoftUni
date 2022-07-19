using System;

namespace T9._Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char line1 = char.Parse(Console.ReadLine());
            char line2 = char.Parse(Console.ReadLine());
            char line3 = char.Parse(Console.ReadLine());
            Console.WriteLine($"{line1}{line2}{line3}");
        }
    }
}
