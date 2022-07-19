using System;

namespace T04MetricConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string inputValue = Console.ReadLine();
            string outputValue = Console.ReadLine();
           double total = 0;
            if (inputValue == "mm" && outputValue == "m")
            {
                total = number / 1000;
            }
            else if (inputValue == "m" && outputValue == "mm")
            {
                total = number * 1000;
            }          
            else if (inputValue == "m" && outputValue == "cm")
            {
                total = number * 100;
            }
            else if (inputValue == "cm" && outputValue == "m")
            {
                total = number / 100;
            }
            else if (inputValue == "cm" && outputValue == "mm")
            {
                total = number * 10;
            }
            else if (inputValue == "mm" && outputValue == "cm")
            {
                total = number / 10;
            }
            Console.WriteLine($"{total:f3}");
        }
    }
}
