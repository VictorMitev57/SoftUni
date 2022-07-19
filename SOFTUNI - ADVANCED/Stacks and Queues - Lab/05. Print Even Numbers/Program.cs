using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 == 0)
                {
                    queue.Enqueue(num[i]);
                }
            }

            Console.WriteLine(String.Join(", ", queue));
        }
    }
}
