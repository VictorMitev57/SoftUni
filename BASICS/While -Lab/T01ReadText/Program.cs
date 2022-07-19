using System;

namespace T01ReadText
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            while (text != "Stop")
            {
                if (text == "Stop")
                {
                    break;
                }
                Console.WriteLine(text);
                text = Console.ReadLine();
            }

        }
    }
}
