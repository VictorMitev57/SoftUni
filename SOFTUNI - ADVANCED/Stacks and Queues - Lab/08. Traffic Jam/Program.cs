using System;
using System.Collections.Generic;

namespace _08._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int passedCars = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            Queue<string> cars = new Queue<string>();
            int passed = 0;
            while (command != "end")
            {
                if (command != "green" && command != "end")
                {
                    cars.Enqueue(command);
                }
                if (command == "green")
                {
                    for (int i = 0; i < passedCars; i++)
                    {
                        if (cars.Count > 0)
                        {
                            Console.WriteLine($"{cars.Peek()} passed!");
                            cars.Dequeue();
                            passed++;
                        }
                    }
                }
                else if (command == "end")
                {

                    break;
                }

                command = Console.ReadLine();

            }
            Console.WriteLine($"{passed} cars passed the crossroads.");
        }
    }
}
