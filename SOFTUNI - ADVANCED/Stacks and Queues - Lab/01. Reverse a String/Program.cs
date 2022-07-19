using System;
using System.Collections.Generic;

namespace _01._Reverse_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> reverse = new Stack<char>();

            foreach (var ch in input)
            {
                reverse.Push(ch);
            }

            while (reverse.Count > 0)
            {
                Console.Write(reverse.Pop());
            }
        }
    }
}
