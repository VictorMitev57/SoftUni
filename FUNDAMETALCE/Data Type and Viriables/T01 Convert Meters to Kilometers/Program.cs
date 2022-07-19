using System;

namespace T01_Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());;
            num *= 0.001;
            Console.WriteLine($"{num:f2}");
        }
    }
}
