using System;
using System.Collections.Generic;
using System.Linq;

namespace T03._School_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shelfWithBooks = new List<string>(Console.ReadLine().Split("&"));
            string command = Console.ReadLine();

            while (command != "Done")
            {
                string[] currCmd = command.Split(" | ");

                int count = 0;
                int secondCount = 0;
                string firstBook = currCmd[1];

                if (currCmd[0] == "Swap Books")
                {

                    string secondBook = currCmd[2];

                    for (int i = 0; i < shelfWithBooks.Count; i++)
                    {
                        int index2 = 0;
                        int index1 = 0;

                        if (shelfWithBooks[i] == firstBook)
                        {
                            count++;
                            index1 = i;
                        }

                        if (shelfWithBooks[i] == secondBook)
                        {
                            secondCount++;
                            index2 = i;
                        }

                        if (count > 0 && secondCount > 0)
                        {

                            shelfWithBooks.Insert(index1, secondBook);
                            shelfWithBooks.RemoveAt(index1 + 1);

                            shelfWithBooks.Insert(index2, firstBook);
                            shelfWithBooks.RemoveAt(index2 + 1);
                            break;
                        }
                    }


                }


                if (currCmd[0] == "Add Book")
                {
                    int index = 0;
                    for (int i = 0; i < shelfWithBooks.Count; i++)
                    {

                        if (shelfWithBooks[i] == firstBook)
                        {
                            count++;
                            index = i;
                        }
                    }

                    if (count == 0)
                    {
                        shelfWithBooks.Insert(index, firstBook);
                    }
                }
                else if (currCmd[0] == "Take Book")
                {
                    for (int i = 0; i < shelfWithBooks.Count; i++)
                    {
                        if (shelfWithBooks[i] == firstBook)
                        {
                            count++;
                            break;
                        }
                    }

                    if (count > 0)
                    {
                        shelfWithBooks.Remove(firstBook);
                    }

                }
                else if (currCmd[0] == "Insert Book")
                {
                    for (int i = 0; i < shelfWithBooks.Count; i++)
                    {
                        if (shelfWithBooks[i] == firstBook)
                        {
                            count++;
                            break;
                        }
                    }

                    if (count == 0)
                    {
                        shelfWithBooks.Add(firstBook);
                    }

                }
                else if (currCmd[0] == "Check Book")
                {
                    string index = firstBook;
                    for (int i = 0; i < shelfWithBooks.Count; i++)
                    {
                        if (index == $"{i}")
                        {
                            Console.WriteLine(shelfWithBooks[i]);
                            break;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", shelfWithBooks));
        }
    }
}
