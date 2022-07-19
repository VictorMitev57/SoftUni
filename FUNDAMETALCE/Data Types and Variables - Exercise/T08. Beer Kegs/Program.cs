using System;
using System.Numerics;
using System.Threading;

namespace T08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            double volume = 0;
            double theBiggest = int.MinValue;
            string theBiggestM = "";
            while (count < n)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                volume = Math.PI * Math.Pow(radius, 2) * height;
                if (theBiggest < volume)
                {
                    theBiggestM = model;
                    theBiggest = volume;
                }
                count++;
            }

            Console.WriteLine(theBiggestM);
        }
    }
}
