using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Stack<string>  operations = new Stack<string>();
            int sum = 0;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                operations.Push(input[i]);
            }

            sum += int.Parse(operations.Pop());
            while (operations.Count > 0)
            {
                if (operations.Peek() == "+")
                {
                    operations.Pop();
                    sum += int.Parse(operations.Pop());
                }
                else if (operations.Peek() == "-")
                {
                    operations.Pop();
                    sum -= int.Parse(operations.Pop());
                }
            }
            Console.WriteLine(sum);
        }
    }
}
