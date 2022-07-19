using System;

namespace TO5PasswordGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            string passowrd = Console.ReadLine();
            if (passowrd == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
