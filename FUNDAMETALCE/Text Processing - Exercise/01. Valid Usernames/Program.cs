using System;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(", ");

            foreach (var word in text)
            {
                if ((word.Length > 3 && word.Length <= 16))
                {
                    bool isValid = true;
                    foreach (char letter in word)
                    {
                        if (!(char.IsLetterOrDigit(letter) || letter == '-' || letter == '_'))
                        {
                            isValid = false;
                            break;
                        } 
                    }

                    if (isValid)
                    {
                        Console.WriteLine(word);
                    }
                }

            }

        }
    }
}
