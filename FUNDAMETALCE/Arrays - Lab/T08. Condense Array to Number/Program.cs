using System;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Channels;

namespace T08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] condensed = new int[numbers.Length-1];
            if (numbers[0] == 1)
            {
                Console.WriteLine(numbers[0]);
                return;
            }
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    condensed[j] = numbers[j] + numbers[j + 1];
                    numbers[j] = condensed[j];
                }
            }
            Console.WriteLine(numbers[0]);
        }
    }
}
