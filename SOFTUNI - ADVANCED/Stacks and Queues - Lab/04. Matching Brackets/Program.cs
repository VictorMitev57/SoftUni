using System;
using System.Collections.Generic;

namespace _04._Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (c == '(')
                {
                    stack.Push(i);
                }
                else if (c == ')')
                {
                    int stratIndex = stack.Pop();
                    int endIndex = i;
                    string subInput = input.Substring(stratIndex, endIndex - stratIndex + 1);
                    Console.WriteLine(subInput);
                }
            }
        }
    }
}
