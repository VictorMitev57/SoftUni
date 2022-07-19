using System;

namespace T08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            double result = Metod(number, power);
            Console.WriteLine(result);
        }

        static double Metod(double number, double power)
        {
            double result = Math.Pow(number, power);
            return result;
        }
    }
}
