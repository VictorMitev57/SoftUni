using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> intigers = new Stack<int>();
            int sum = 0;
            foreach (var num in numbers)
            {
                intigers.Push(num);
            }

            string input = Console.ReadLine().ToLower();
            string[] command = input.Split();
            while (command[0] != "end")
            {
                if (command[0] == "add")
                {
                    int n1 = int.Parse(command[1]);
                    int n2 = int.Parse(command[2]);

                    intigers.Push(n1);
                    intigers.Push(n2);
                }
                else if (command[0] == "remove")
                {
                    int num = int.Parse(command[1]);
                    if (num <= intigers.Count)
                    {
                        for (int i = 0; i < num; i++)
                        {
                            intigers.Pop();
                        }
                    }
                }
                input = Console.ReadLine().ToLower();
                command = input.Split();
            }

            sum += intigers.Sum();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
