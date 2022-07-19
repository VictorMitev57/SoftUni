using System;

namespace T07MinNum
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int minNum = int.MaxValue;
            int num = 0;
            while (command != "Stop")
            {
                num = int.Parse(command);
                if (minNum > num)
                {
                    minNum = num;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(minNum);
        }
    }
}
