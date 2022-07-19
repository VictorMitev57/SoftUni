using System;

namespace T04._Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            double years = centuries * 100;
            double days = (long)(years * 365.2422);
            double hours = (long)(days * 24);
            double min = (long)(hours * 60);
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {min} minutes");
        }
    }
}
