using System;

namespace T03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int courses = 0;
            int remainder = 0;
            if (numberOfPeople / capacity == 0)
            {
                courses = (int)Math.Ceiling((double)numberOfPeople / capacity);
                Console.WriteLine(courses);
            }
            else
            {
                courses = (int)Math.Ceiling((double)numberOfPeople / capacity);
                Console.WriteLine(courses);
            }
        }
    }
}
