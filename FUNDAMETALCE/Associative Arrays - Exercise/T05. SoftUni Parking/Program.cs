using System;
using System.Collections.Generic;

namespace T05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string username = "";
            string license = "";

            Dictionary<string, string> register = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "register")
                {
                    username = input[1];
                    license = input[2];
                    if (!register.ContainsKey(username))
                    {
                        register[username] = license;
                        Console.WriteLine($"{username} registered {license} successfully");
                    }

                    else if (register.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {license}");
                    }
                }

                else if (input[0] == "unregister")
                {
                    username = input[1];
                    if (!register.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else if (register.ContainsKey(username))
                    {
                        register.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }

            foreach (var users in register)
            {
                Console.WriteLine($"{users.Key} => {users.Value}");
            }
        }
    }
}
