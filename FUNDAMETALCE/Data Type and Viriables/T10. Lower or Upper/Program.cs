using System;

namespace T10._Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter = char.Parse(Console.ReadLine());
            bool isUpper = char.IsUpper(letter);
            if (isUpper)
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");

            }    }
    }
}
