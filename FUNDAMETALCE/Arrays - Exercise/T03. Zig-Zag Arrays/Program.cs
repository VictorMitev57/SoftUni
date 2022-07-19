using System;
using System.Linq;

namespace T03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstArray = new int[n];
            int[] secondArray = new int[n];


            for (int i = 0; i < n; i++)
            {
                int[] line = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                if (i % 2 ==0)
                {
                    firstArray[i] = line[0];
                    secondArray[i] = line[1];
                }
                else
                {
                    firstArray[i] = line[1];
                    secondArray[i] = line[0];
                }
            }

            Console.WriteLine(string.Join(" ", firstArray));
            Console.WriteLine(string.Join(" ", secondArray));
        }
    }
}
