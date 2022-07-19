using System;
using System.Linq;

namespace _04._Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] demensions = Console.ReadLine().Split();
            int rowCount = int.Parse(demensions[0]);
            int colCount = int.Parse(demensions[1]);
            string[,] matrix = new string[rowCount, colCount];

            for (int row = 0; row < rowCount; row++)
            {
                string[] line = Console.ReadLine().Split();
                for (int col = 0; col < colCount; col++)
                {
                    matrix[row, col] = line[col];
                }
            }
            bool Valid = false;
            while (true)
            
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "END")
                {
                    break;
                }
                if (command[0] == "swap" && command.Length == 5)
                {
                    int row1 = int.Parse(command[1]);
                    int col1 = int.Parse(command[2]);
                    int row2 = int.Parse(command[3]);
                    int col2 = int.Parse(command[4]);
                    if (row1 >= 0 && row1 < rowCount &&
                        col1 >= 0 && col1 < colCount &&
                        row2 >= 0 && row2 < rowCount &&
                        col2 >= 0 && col2 < colCount)
                    {
                        string firstElement = matrix[row1, col1];
                        string secondElement = matrix[row2, col2];

                        matrix[row1, col1] = secondElement;
                        matrix[row2, col2] = firstElement;

                        for (int row = 0; row < rowCount; row++)
                        {
                            for (int col = 0; col < colCount; col++)
                            {
                                Console.Write(matrix[row, col] + " ");

                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }

                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

            }
        }
    }
}
