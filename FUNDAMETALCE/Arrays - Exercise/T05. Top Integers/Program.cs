using System;
using System.Linq;

namespace T05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int biggestNum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                biggestNum = numbers[i];
                if (biggestNum > numbers[i + 1])
                {
                    
                }
                else
                {
                    biggestNum = numbers[i + 1];
                }
            }
        }
    }
}
