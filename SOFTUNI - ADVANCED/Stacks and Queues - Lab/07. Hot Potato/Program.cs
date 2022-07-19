using System;
using System.Collections.Generic;

namespace _07._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] children = Console.ReadLine().Split();
            int passes = int.Parse(Console.ReadLine());

            Queue<string> hotPotato = new Queue<string>();

            for (int i = 0; i < children.Length; i++)
            {
                hotPotato.Enqueue(children[i]); 
            }

            while (hotPotato.Count > 1)
            {
                for (int i = 1; i <= passes - 1; i++)
                {
                    var child = hotPotato.Dequeue();
                    hotPotato.Enqueue(child);
                }
                var lostPlayer = hotPotato.Dequeue();
                Console.WriteLine($"Removed {lostPlayer}");
            }
            var lastPlayer = hotPotato.Dequeue();
            Console.WriteLine($"Last is {lastPlayer}");
        }
    }
}
