using System;

namespace T04PrintAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            int sum = 0; 

            for (int currNum = startNum; currNum <= endNum; currNum++)
            {
                Console.Write($"{currNum} ");
                sum += currNum;
            }
            Console.WriteLine($"\nSum: {sum}");
        }
    }
}
