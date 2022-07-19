using System;

namespace TO6AreaOFFiguries
{
    class Program
    {
        static void Main(string[] args)
        {
            string figurue =  Console.ReadLine();
            double area = 0;
            if (figurue == "square")
            {

                double a = double.Parse(Console.ReadLine());
                area = a * a;
            }
            else if (figurue == "rectangle")
            {

                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                area = a * b;
            }
            else if (figurue == "circle")
            {

                double r = double.Parse(Console.ReadLine());
                area = Math.PI * r * r;
            }
            else if (figurue == "triangle")
            {

                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                area = a * h / 2;
            }
            Console.WriteLine($"{area:f3}");
        }
    }
}
