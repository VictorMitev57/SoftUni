using System;

namespace T03SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while (sum < num)
            {
                int currentNUm = int.Parse(Console.ReadLine());
                sum += currentNUm;
            }
            Console.WriteLine(sum);
        }
    }
}
