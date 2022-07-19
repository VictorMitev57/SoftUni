using System;

namespace T08._Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int times = 0;
            for (int i = 1; i <= n; i++)
            {
                while (times < i)
                {
                    Console.Write($"{i} ");
                    times++;
                }
                times = 0;
                Console.WriteLine();
            }
        }
    }
}
