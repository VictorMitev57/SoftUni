using System;

namespace T08Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int year = 1;
            string grade = Console.ReadLine();
            int fail = 0;
            double grade1 = 0;
            double sum = 0;
            while (year <= 12)
            {
                grade1 = double.Parse(grade);
                sum += grade1;
                if (grade1 < 4)
                {
                    fail++;
                    if (fail > 1)
                    {
                        year--;
                        Console.WriteLine($"{name} has been excluded at {year} grade");
                        break;
                    }
                }
                year++;
                if (year > 12)
                {
                    break;
                }
                grade = Console.ReadLine();
            }
            if (fail == 2)
            {
                return;
            }
            double averageGrade = sum / 12;
            Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
 
        }
    }
}
