using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;

namespace T02._Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "Finish")
            {
                string[] currCmd = command.Split();
                int value = 0;
                int replacment = 0;

                if (currCmd[0] == "Add")
                {
                    value = int.Parse(currCmd[1]);
                    numbers.Add(value);
                }

                else if (currCmd[0] == "Remove")
                {
                    value = int.Parse(currCmd[1]);
                    numbers.Remove(value);
                }

                else if (currCmd[0] == "Replace")
                {
                    replacment = int.Parse(currCmd[2]);
                    value = int.Parse(currCmd[1]);
                    int index = 0;
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == value)
                        {
                            index = i;
                            break;
                        }
                    }
                    numbers.Insert(index, replacment);
                    numbers.RemoveAt(index + 1);
                }

                else if (currCmd[0] == "Collapse")
                {
                    value = int.Parse(currCmd[1]);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] < value)
                        {
                            numbers.Remove(numbers[i]);
                            i--;
                        }

                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }

}
