using System;

namespace _02.Truffle_Hunter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int whiteTrufCount = 0;
            int summerTrufCount = 0;
            int blackTrufCount = 0;
            int trufEatenByBoar = 0;

            int size = int.Parse(Console.ReadLine());
            string[,] matrix = new string[size, size];

            for (int row = 0; row < size; row++)
            {
                string[] line = Console.ReadLine().Split();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = line[col];
                }
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "Stop")
                {
                    break;
                }
                else if (command[0] == "Collect")
                {
                    int row = int.Parse(command[1]);
                    int col = int.Parse(command[2]);

                    if (matrix[row, col] == "B")
                    {
                        matrix[row, col] = "-";
                        blackTrufCount++;
                    }
                    else if (matrix[row, col] == "S")
                    {
                        matrix[row, col] = "-";
                        summerTrufCount++;
                    }
                    else if (matrix[row, col] == "W")
                    {
                        matrix[row, col] = "-";
                        whiteTrufCount++;
                    }

                }
                else if (command[0] == "Wild_Boar")
                {
                    int row = int.Parse(command[1]);
                    int col = int.Parse(command[2]);
                    string direction = command[3];

                    if (direction == "up")
                    {
                        for (int r = row; r >= 0; r -= 2)
                        {
                            if (matrix[r, col] == "B")
                            {
                                matrix[r, col] = "-";
                                trufEatenByBoar++;
                            }
                            else if (matrix[r, col] == "S")
                            {
                                matrix[r, col] = "-";
                                trufEatenByBoar++;
                            }
                            else if (matrix[r, col] == "W")
                            {
                                matrix[r, col] = "-";
                                trufEatenByBoar++;
                            }
                        }
                    }
                    else if (direction == "down")
                    {
                        for (int r = row; r < size; r += 2)
                        {
                            if (matrix[r, col] == "B")
                            {
                                matrix[r, col] = "-";
                                trufEatenByBoar++;
                            }
                            else if (matrix[r, col] == "S")
                            {
                                matrix[r, col] = "-";
                                trufEatenByBoar++;
                            }
                            else if (matrix[r, col] == "W")
                            {
                                matrix[r, col] = "-";
                                trufEatenByBoar++;
                            }
                        }
                    }
                    else if (direction == "left")
                    {
                        for (int c = col; c >= 0; c -= 2)
                        {
                            if (matrix[row, c] == "B")
                            {
                                matrix[row, c] = "-";
                                trufEatenByBoar++;
                            }
                            else if (matrix[row, c] == "S")
                            {
                                matrix[row, c] = "-";
                                trufEatenByBoar++;
                            }
                            else if (matrix[row, c] == "W")
                            {
                                matrix[row, c] = "-";
                                trufEatenByBoar++;
                            }
                        }
                    }
                    else if (direction == "right")
                    {
                        for (int c = col; c < size; c += 2)
                        {
                            if (matrix[row, c] == "B")
                            {
                                matrix[row, c] = "-";
                                trufEatenByBoar++;
                            }
                            else if (matrix[row, c] == "S")
                            {
                                matrix[row, c] = "-";
                                trufEatenByBoar++;
                            }
                            else if (matrix[row, c] == "W")
                            {
                                matrix[row, c] = "-";
                                trufEatenByBoar++;
                            }
                        }
                    }

                }
            }
            Console.WriteLine($"Peter manages to harvest {blackTrufCount} black, " +
                $"{summerTrufCount} summer, " +
                $"and {whiteTrufCount} white truffles.");
            Console.WriteLine($"The wild boar has eaten {trufEatenByBoar} truffles.");

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(matrix[row, col] + " ");

                }
                Console.WriteLine();
            }
        }
    }
}
