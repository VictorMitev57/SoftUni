using System;

namespace T04TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            double jouries = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            double averageGrades = 0;
            double averageOfAllGrades = 0;
            int jouriesGrades = 0;
            int gradesCounter = 0;
            while (command != "Finish")
            {
                while (jouriesGrades < jouries)
                {
                    double grades = double.Parse(Console.ReadLine());
                    jouriesGrades++;
                    gradesCounter++;
                    averageGrades += grades;
                    averageOfAllGrades += grades;
                }
                averageGrades = averageGrades / jouriesGrades;
                Console.WriteLine($"{command} - {averageGrades:f2}.");
                jouriesGrades = 0;
                averageGrades = 0;
                command = Console.ReadLine();
            }
            averageOfAllGrades = averageOfAllGrades / gradesCounter;
            Console.WriteLine($"Student's final assessment is {averageOfAllGrades:f2}.");
        }
    }
}
