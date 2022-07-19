using System;

namespace T01NumbersEndingin7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int iterator = 7; iterator <= 1000; iterator+=10)
            {
                Console.WriteLine(iterator);
                //if (iterator % 10 == 7)
                //{
                //    Console.WriteLine(iterator);
                //}
            }
        }
    }
}
