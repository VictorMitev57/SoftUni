using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Unique_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string nameCurr = Console.ReadLine();
                names.Add(nameCurr);

            }

            foreach (var curName in names)
            {
                Console.WriteLine(string.Join(Environment.NewLine, curName));
            }
        }
    }
}