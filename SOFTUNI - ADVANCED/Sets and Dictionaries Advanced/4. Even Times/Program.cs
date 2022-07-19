using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> numbers = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int currNum =  int.Parse(input);

                if (!numbers.ContainsKey(currNum))
                {
                    numbers.Add(currNum, 1);
                }
                else
                {
                    numbers[currNum]++;
                }
            }
            Console.WriteLine(numbers.First(entry => entry.Value % 2 == 0).Key);
        }
    }
}
