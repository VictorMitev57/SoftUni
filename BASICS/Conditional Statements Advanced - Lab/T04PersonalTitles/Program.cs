using System;

namespace t04personaltitles
{
    class program
    {
        static void main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            if (gender == "m")
            {
                if (age >= 16)
                {
                    Console.WriteLine("Mr.");
                }
                else
                {
                    Console.WriteLine("Master");
                }
            }
            if (gender == "f")
            {
                if (age >= 16)
                {
                    Console.WriteLine("MS.");
                }
                else
                {
                    Console.WriteLine("Miss");
                }
            }
        }
    }
}
