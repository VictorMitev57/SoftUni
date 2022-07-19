using System;
using System.Linq;

namespace T01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int waggons = int.Parse(Console.ReadLine());
            int[] passengers = new int[waggons];
            int sum = 0;
            for (int i = 0; i < passengers.Length; i++)
            {
                passengers[i] = int.Parse(Console.ReadLine());
                sum += passengers[i];
            }
            Console.Write(string.Join(" ", passengers));
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
