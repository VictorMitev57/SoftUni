using System;
using System.Linq;

namespace _02._Wall_Destroyer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];

            for (int row = 0; row < size; row++)
            {
                char[] line = Console.ReadLine().ToCharArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = line[col];
                }
            }

            int rodCount = 0;
            int holeCount = 0;
            int curRow = 0;
            int currCol = 0;
            bool hitted = false;
            int finalPosition = 0;

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (matrix[row, col] == 'V')
                    {
                        curRow = row;
                        currCol = col;
                    }
                }
            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }
                else if (command == "up")
                {
                    for (int r = curRow; r >= 0; r--)
                    {
                        if (r >= 0)
                        {
                            if (matrix[r, currCol] == 'R')
                            {
                                Console.WriteLine("Vanko hit a rod!");
                                curRow = r + 1;
                                rodCount++;
                            }
                            else if (matrix[r, currCol] == 'C')
                            {
                                matrix[r, currCol] = 'E';
                                holeCount++;
                                hitted = true;
                                break;
                            }
                            else if (matrix[r, currCol] == '-')
                            {
                                matrix[r, currCol] = '*';
                                holeCount++;
                            }
                            else if (matrix[r, currCol] == '*')
                            {
                                Console.WriteLine($"The wall is already destroyed at position {matrix[r, currCol]}!");
                            }
                        }
                    }
                }
                else if (command == "down")
                {
                    for (int r = curRow; r < size; r++)
                    {
                        if (r < size)
                        {
                            if (matrix[r, currCol] == 'R')
                            {
                                Console.WriteLine("Vanko hit a rod!");
                                curRow = r - 1;
                                rodCount++;

                            }
                            else if (matrix[r, currCol] == 'C')
                            {
                                matrix[r, currCol] = 'E';
                                holeCount++;
                                hitted = true;
                                break;
                            }
                            else if (matrix[r, currCol] == '-')
                            {
                                matrix[r, currCol] = '*';
                                holeCount++;
                            }
                            else if (matrix[r, currCol] == '*')
                            {
                                Console.WriteLine($"The wall is already destroyed at position {matrix[r, currCol]}!");
                            }
                        }
                    }
                }
                else if (command == "left")
                {
                    for (int c = currCol; c >= 0; c--)
                    {
                        if (c >= 0)
                        {
                            if (matrix[curRow, c] == 'R')
                            {
                                Console.WriteLine("Vanko hit a rod!");
                                currCol = c + 1;
                                rodCount++;

                            }
                            else if (matrix[curRow, c] == 'C')
                            {
                                matrix[curRow, c] = 'E';
                                holeCount++;
                                hitted = true;
                                break;
                            }
                            else if (matrix[curRow, c] == '-')
                            {
                                matrix[curRow, c] = '*';
                                holeCount++;
                            }
                            else if (matrix[curRow, c] == '*')
                            {
                                Console.WriteLine($"The wall is already destroyed at position {matrix[curRow, c]}!");
                            }
                        }
                    }
                }
                else if (command == "right")
                {
                    for (int c = currCol; c < size; c++)
                    {
                        if (c < size)
                        {
                            if (matrix[curRow, c] == 'R')
                            {
                                Console.WriteLine("Vanko hit a rod!");
                                currCol = c - 1;
                                rodCount++;

                            }
                            else if (matrix[curRow, c] == 'C')
                            {
                                matrix[curRow, c] = 'E';
                                holeCount++;
                                hitted = true;
                                break;
                            }
                            else if (matrix[curRow, c] == '-')
                            {
                                matrix[curRow, c] = '*';
                                holeCount++;
                            }
                            else if (matrix[curRow, c] == '*')
                            {
                                Console.WriteLine($"The wall is already destroyed at position {matrix[curRow, c]}!");
                            }
                        }
                    }
                }
            }
            if (hitted == true)
            {
                Console.WriteLine($"Vanko got electrocuted, but he managed to make {holeCount} hole(s).");
            }
            else if (hitted == false)
            {
                Console.WriteLine($"Vanko managed to make {holeCount} hole(s) and he hit only {rodCount} rod(s).");
            }
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
