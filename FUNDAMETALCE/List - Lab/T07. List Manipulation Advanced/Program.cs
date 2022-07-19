using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace T07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> check = numbers;

            int sum = 0;
            int isItTrue = 0;
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] token = command.Split();

                switch (token[0])
                {
                    case "Contains":
                        int numberToContains = int.Parse(token[1]);
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numberToContains == numbers[i])
                            {
                                isItTrue++;
                            }
                        }

                        if (isItTrue > 0)
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 ==0)
                            {
                                Console.Write($"{numbers[i]} ");
                            }
                        }

                        Console.WriteLine();
                        break;
                    case "PrintOdd":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 1)
                            {
                                Console.Write($"{numbers[i]} ");
                            }
                        }

                        Console.WriteLine();
                        break;
                    case "GetSum":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            sum += numbers[i];
                        }

                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        string comdition = (token[1]);
                        int index = int.Parse(token[2]);
                        switch (comdition)
                        {
                            case "<":
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    if (numbers[i] < index)
                                    {
                                        Console.Write($"{numbers[i]} ");
                                    }
                                }

                                Console.WriteLine();
                                break;
                            case ">":
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    if (numbers[i] > index)
                                    {
                                        Console.Write($"{numbers[i]} ");
                                    }
                                }

                                Console.WriteLine();
                                break;
                            case "<=":
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    if (numbers[i] <= index)
                                    {
                                        Console.Write($"{numbers[i]} ");
                                    }
                                }

                                Console.WriteLine();
                                break;
                            case ">=":
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    if (numbers[i] >= index)
                                    {
                                        Console.Write($"{numbers[i]} ");
                                    }
                                }

                                Console.WriteLine();
                                break;
                        }
                        break;

                }

            }
        }
    }
}
