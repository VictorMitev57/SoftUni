using System;

namespace T05Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;
            int count = 0;
            for (int i = username.Length -1; i >= 0; i--)
            {
                password += username[i];
            }
            string input = Console.ReadLine();
            while (input != password)
            {
                count++;
                if (count > 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                input = Console.ReadLine();
                Console.WriteLine("Incorrect password. Try again.");
            }
            Console.WriteLine($"User {username} logged in.");
        }
    }
}
