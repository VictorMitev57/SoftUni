using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Basic_Stack_operation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = numbers[0]; //numbers to push 
            int s = numbers[1]; //numbers to pull
            int x = numbers[2]; //numbers to peek

            List<int> numbersList = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                stack.Push(numbersList[i]);
            }
            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }

            if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else    
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
    