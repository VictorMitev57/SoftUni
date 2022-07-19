using System;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
           var input = Console.ReadLine().Split();
            int finalSum = GetsStringSum(input[0], input[1]);
            Console.WriteLine(finalSum);
        }

        private static int GetsStringSum(string first, string second)
        {
            int sum = 0;
            int minLenght = Math.Min(first.Length, second.Length);

            for (int i = 0; i < minLenght; i++)
            {
                sum += first[i] * second[i];

            }

            string longestLenght = first;
            if (longestLenght.Length < second.Length)
            {
                longestLenght = second;
            }

            for (int i = minLenght; i < longestLenght.Length; i++)
            {
                sum += longestLenght[i];
            }

            return sum;
        }
    }
}
