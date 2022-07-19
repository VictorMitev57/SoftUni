using System;
using System.Linq;

namespace T04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int rotation = int.Parse(Console.ReadLine());

            for (int rotations = 0; rotations < rotation; rotations++)
            {
                int temp = numbers[0];
                for (int operation = 0; operation < numbers.Length - 1; operation++)
                {
                    numbers[operation] = numbers[operation + 1];
                }

                numbers[numbers.Length -1] = temp;
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
