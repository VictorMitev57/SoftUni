using System;

namespace T02ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            int grade = int.Parse(Console.ReadLine());
            int badgrades = 0;
            double gradeCounter = 0;
            double allgrades = 0;
            string savedNames = "";
            while (name != "Enough")
            {
                gradeCounter += grade;
                allgrades++;
                if (grade <= 4)
                {
                    badgrades++;
                    if (badgrades == badGrades)
                    {
                        Console.WriteLine($"You need a break, {badGrades} poor grades.");
                        break;
                    }
                }
                savedNames = name;
                name = Console.ReadLine();
                if (name == "Enough")
                {
                    break;
                }

                grade = int.Parse(Console.ReadLine());
                
            }
            if (name == "Enough")
            {
                double averageScore = gradeCounter / allgrades;
                Console.WriteLine($"Average score: {averageScore:f2}");
                Console.WriteLine($"Number of problems: {allgrades}");
                Console.WriteLine($"Last problem: {savedNames}");
            }
        }
    }
}
