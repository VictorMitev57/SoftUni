using System;

namespace T03._Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num = decimal.Parse(Console.ReadLine());
            decimal realNum = 0;
            decimal exactNum = 0;
            for (int i = 1; i <= num; i++)
            {
                realNum = decimal.Parse(Console.ReadLine());
                exactNum += realNum;
            }
            Console.WriteLine($"{exactNum}");
        }
    }
}
