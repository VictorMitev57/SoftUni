using System;
using System.Globalization;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(@"\");
            int fileName = input.Length - 1;

            string[] token = input[fileName].Split(".");

            //File name: Template
            //File extension: pptxs

            Console.WriteLine($"File name: {token[0]}");
            Console.WriteLine($"File extension: {token[1]}");
        }
    }
}
