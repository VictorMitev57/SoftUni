using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Maximum_and_minimum_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersGiven = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < numbersGiven; i++)
            {
                string[] numbers = Console.ReadLine().Split(" ");
                int command = int.Parse(numbers[0]);

                if (command == 1)
                {
                    int numberAded = int.Parse(numbers[1]);
                    stack.Push(numberAded);
                }
                else if (command == 2)
                {
                    if (stack.Count > 0)    
                    {
                        stack.Pop();
                    }     
                }
                else if (command == 3)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Max());
                    }
                  
                }
                else if (command == 4)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Min());
                    }

                }
            }
            if (true)
            {
                Console.WriteLine(string.Join(", ", stack));
            }
        }
    }
}
