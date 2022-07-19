using System;

namespace _07._Knight_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            string[,] matrix = new string[size, size];

            for (int row = 0; row < size; row++)
            {
                string line = Console.ReadLine();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = line;
                }
            }

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (matrix[row, col] == "K")
                    {
                        if (matrix[row, col] == matrix[row, col - 1] ||
                            matrix[row, col] == matrix[row, col + 1] ||
                            matrix[row, col] == matrix[row + 1, col - 1] ||
                            matrix[row, col] == matrix[row + 1, col] ||
                            matrix[row, col] == matrix[row + 1, col + 1])
                        {
                            int firstEl = int.Parse(matrix[row, col]);
                        }
                    }
                }
            }
        }
    }
}
