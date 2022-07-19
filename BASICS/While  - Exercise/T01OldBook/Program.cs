using System;

namespace T01OldBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchedBook = Console.ReadLine();
            string nextBooks = Console.ReadLine();
            int booksCounter = 0;
            while (nextBooks != "No More Books")
            {
                if (nextBooks == searchedBook)
                {
                    Console.WriteLine($"You checked {booksCounter} books and found it.");
                    break;
                }
                booksCounter++;
                nextBooks = Console.ReadLine();
            }
            if (nextBooks == "No More Books")
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {booksCounter} books.");
            }
        }
    }
}
