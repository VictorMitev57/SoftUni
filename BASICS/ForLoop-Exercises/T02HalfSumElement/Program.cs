using System;

namespace T02HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxNum = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                if (num > maxNum)
                {
                    maxNum = num;
                }
            }
            int SumWithoutMaxNum = sum - maxNum;
            if (maxNum == SumWithoutMaxNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + maxNum);
            }
            else
            {
                int diff = Math.Abs(maxNum - SumWithoutMaxNum);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
