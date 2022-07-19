using System;
using System.Threading.Channels;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string encrypted = String.Empty;
            foreach (char letter in input)
            {
                int currPosition = letter;
                currPosition += 3;
                encrypted += (char)currPosition;
            }

            Console.WriteLine(encrypted);
        }
    }
}
