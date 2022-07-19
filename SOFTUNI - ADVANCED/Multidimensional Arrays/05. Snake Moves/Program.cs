using System;

namespace _05._Snake_Moves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] demensions = Console.ReadLine().Split();
            int rowCount = int.Parse(demensions[0]);
            int colCount = int.Parse(demensions[1]);

            char[,] matrix = new char[rowCount, colCount];
            string snake = Console.ReadLine();

            int index = 0;
            for (int row = 0; row < rowCount; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < colCount; col++)
                    {
                        matrix[row, col] = snake[index];
                        index++;
                        if (index >= snake.Length)
                        {
                            index = 0;
                        }
                    }
                }
                else
                {
                    for (int col = colCount - 1; col >= 0; col--)
                    {
                        matrix[row, col] = snake[index];
                        index++;
                        if (index >= snake.Length)
                        {
                            index = 0;
                        }
                    }
                }
            }

            for (int row = 0; row < rowCount; row++)
            {
                for (int col = 0; col < colCount; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
