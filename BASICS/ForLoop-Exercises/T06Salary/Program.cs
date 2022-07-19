using System;

namespace T06Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            const double facebook= 150;
            const double instagram = 100;
            const double reddit = 50;
            int openTabs = int.Parse(Console.ReadLine());
            double salary = int.Parse(Console.ReadLine());
            for (int i = 1; i <= openTabs; i++)
            {
                if (salary > 0)
                {
                    string text = Console.ReadLine();
                    if (text == "Facebook")
                    {
                        salary -= facebook;
                    }
                    if (text == "Instagram")
                    {
                        salary -= instagram;
                    }
                    if (text == "Reddit")
                    {
                        salary -= reddit;
                    }
                }
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }
            if (salary > 0)
            {
                Console.WriteLine(salary);

            }
        }
    }
}
